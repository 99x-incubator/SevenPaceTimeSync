using Newtonsoft.Json;
using SevenPaceTimeSync.models;
using SevenPaceTimeSync.Services;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TimetrackerOnline.BusinessLayer.Models;

namespace SevenPaceTimeSync
{
    internal class Program
    {
        private const string DateParametersFormat = @"yyyy-MM-dd";
        private const string sevenPaceApiUrl = "https://compello.timehub.7pace.com/api/odata";

        private static void Main(string[] args)
        {
            // TODO: Need to get the token in a secure way
            string token = ConfigurationManager.AppSettings["Token"].ToString();

            // Create OData service context
            var context = new TimetrackerOdataContext(new Uri(sevenPaceApiUrl), token);

            //TODO: DEFINE DATE PERIOD HERE
            // Perform query
            var startDate = DateTime.Today.AddDays(-7).ToString(DateParametersFormat);
            var endDate = DateTime.Today.ToString(DateParametersFormat);

            var timeExport = context.Container.TimeExport(startDate, endDate, null, null, null);
            timeExport = timeExport.AddQueryOption("api-version", "2.1");

            ExportItemViewModelApi[] timeExportResult = timeExport.ToArray();

            UserTaskMapping userTaskMapping = ReadMappingJson();

            if (userTaskMapping?.Users != null && userTaskMapping?.Tasks != null)
            {
                foreach (var user in userTaskMapping.Users)
                {
                    ExportItemViewModelApi[] userTaskCollection = 
                        timeExportResult.Where(x => x.TeamMember == user.VstsName)?.ToArray();

                    if (userTaskCollection != null)
                    {
                        foreach (var task in userTaskCollection)
                        {
                            string taskCode =
                                userTaskMapping.Tasks.FirstOrDefault(x => x.VstsTask == task.ActivityType)?.GoodTimesTask;
                            string username = user.SharePointName;

                            if (taskCode != null)
                            {
                                // TODO: Need to check about the time zone.
                                bool result = GoodTimeDataService.AddNewLog(username, task.RecordDate.DateTime, task.TimeTracked, CreateTaskComment(task), taskCode);
                               
                            }
                           
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        private static string GetFolderPathFromFilePath(string filePath)
        {
            string folderPath = null;

            try
            {
                Uri fileUri = new Uri(filePath);
                folderPath = new FileInfo(fileUri.LocalPath).DirectoryName;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return folderPath;
        }

        private static string GetAssemblyFolderPath()
        {
            string assemblyPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            return GetFolderPathFromFilePath(assemblyPath);
        }

        // Return the name of the method that called this one.
        private static string GetMethodName()
        {
            return new StackTrace(1).GetFrame(0).GetMethod().Name;
        }

        private static UserTaskMapping ReadMappingJson()
        {
            UserTaskMapping userTaskMapping = null;
            try
            {
                string filePath = Path.Combine(GetAssemblyFolderPath(), ConfigurationManager.AppSettings["MappingFilePath"].ToString());

                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    userTaskMapping = (UserTaskMapping)serializer.Deserialize(file, typeof(UserTaskMapping));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userTaskMapping;
        }

        private static string CreateTaskComment(ExportItemViewModelApi modelApi)
        {
            string comment = $"Parent - [{modelApi.ParentTFSID}][{modelApi.ParentTFSTitle}] \r\n" +
                             $"Task - [{modelApi.TFSID}][{modelApi.TFSTitle}] \r\n" +
                             $"Comment - [{modelApi.Comment}] \r\n";

            return comment;
        }
    }
}
