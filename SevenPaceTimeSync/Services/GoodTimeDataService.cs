using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SevenPaceTimeSync.Services
{
    public class GoodTimeDataService
    {
        private static Dictionary<string, int> taskCodes = new Dictionary<string, int>();
        private static int GetTaskIDbyCode(string code)
        {
            int retVal = 0;
            try
            {
                ClientContext client = new ClientContext(ConfigurationManager.AppSettings.Get("SPURL"));
                //Console.WriteLine("Total Records found for Sync: " + newTasks.Count);
                var securePassword = new SecureString();
                foreach (var c in ConfigurationManager.AppSettings.Get("SPPassword"))
                {
                    securePassword.AppendChar(c);
                }

                client.Credentials = new SharePointOnlineCredentials(ConfigurationManager.AppSettings.Get("SPUsername"), securePassword);

                List list = client.Web.Lists.GetByTitle("Tasks");


                CamlQuery query = CamlQuery.CreateAllItemsQuery();

                query.ViewXml = "<View><Query><Where>" +
                          "<Eq>" +
                              "<FieldRef Name='TaskID' />" +
                              "<Value Type='Text'>" + code + "</Value>" +
                          "</Eq>" +
                      " </Where>" +
                      "</Query>" +
                      "</View>";

                ListItemCollection items = list.GetItems(query);

                // Retrieve all items in the ListItemCollection from List.GetItems(Query). 
                client.Load(items);
                client.ExecuteQuery();

                foreach (ListItem listItem in items)
                {
                    retVal = int.Parse(listItem["ID"].ToString());
                }

                if (retVal == 0)
                {
                    throw new Exception("Invalid task code");
                }
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool AddNewLog(string userName, DateTime StartDate, double duration, string comment, string taskCode)
        {
            bool retVal = false;
            try
            {
                userName = string.Concat(userName, "@99x.lk");
                int taskID = 0;
                if (taskCodes.ContainsKey(taskCode))
                {
                    taskID = taskCodes[taskCode];
                }
                else
                {
                    taskID = GetTaskIDbyCode(taskCode);
                    taskCodes.Add(taskCode, taskID);
                }
                ClientContext client = new ClientContext(ConfigurationManager.AppSettings.Get("SPURL"));
                //Console.WriteLine("Total Records found for Sync: " + newTasks.Count);
                var securePassword = new SecureString();
                foreach (var c in ConfigurationManager.AppSettings.Get("SPPassword"))
                {
                    securePassword.AppendChar(c);
                }

                client.Credentials = new SharePointOnlineCredentials(ConfigurationManager.AppSettings.Get("SPUsername"), securePassword);

                List list = client.Web.Lists.GetByTitle("Log");

                string startDateOnly = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day).ToString();

                ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
                ListItem newItem = list.AddItem(itemCreateInfo);
                newItem["Title"] = userName;
                newItem["Start"] = DateTime.Parse(startDateOnly).AddHours(8).ToString("yyyy-MM-dd HH:mm"); ;
                newItem["End"] = DateTime.Parse(startDateOnly).AddHours(duration).AddHours(8).ToString("yyyy-MM-dd HH:mm");
                newItem["Duration"] = Math.Round(duration,2);
                newItem["Comment"] = comment;
                newItem["Task"] = taskID;

                newItem.Update();

                client.ExecuteQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting user");
            }

            return true;
        }
    }
}
