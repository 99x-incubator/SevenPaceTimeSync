using SevenPaceTimeSync.Services;
using System;
using System.Configuration;
using System.Linq;
using TimetrackerOnline.BusinessLayer.Models;

namespace SevenPaceTimeSync
{
    internal class Program
    {
        private const string DateParametersFormat = @"yyyy-MM-dd";
        private const string sevenPaceApiUrl = "https://compello.timehub.7pace.com/api/odata";

        private static void Main( string[] args )
        {
            // TODO: Need to get the token in a secure way
            string token = ConfigurationManager.AppSettings["Token"].ToString();

            // Create OData service context
            var context = new TimetrackerOdataContext(new Uri(sevenPaceApiUrl), token);

            //TODO: DEFINE DATE PERIOD HERE
            // Perform query
            var startDate = DateTime.Today.AddYears( -1 ).ToString( DateParametersFormat );
            var endDate = DateTime.Today.ToString( DateParametersFormat );

            var timeExport = context.Container.TimeExport( startDate, endDate, null, null, null );
            timeExport = timeExport.AddQueryOption( "api-version", "2.1" );

            ExportItemViewModelApi[] timeExportResult = timeExport.ToArray();

            // Print out the result
            foreach ( var row in timeExport)
            {
                Console.WriteLine( "{0:g} {1} {2} {3} {4} {5}", row.RecordDate, row.UserID, row.TeamMember, row.Comment, 
                    row.WorkItemType, row.TimeTracked );
            }


            Console.ReadKey();
        }
    }
}