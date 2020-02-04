using System;
using Microsoft.OData.Client;

namespace SevenPaceTimeSync.Services
{
    public class TimetrackerOdataContext
    {
        private readonly Uri _serviceUri;
        private readonly string _token;

        public TimetrackerOdataContext( Uri serviceUri )
        {
            _serviceUri = serviceUri;

            Container = new Default.Container( serviceUri );
            Container.Credentials = System.Net.CredentialCache.DefaultCredentials;
        }

        public TimetrackerOdataContext( Uri serviceUri, string token )
        {
            _serviceUri = serviceUri;
            _token = token;

            Container = new Default.Container( serviceUri );

            Container.SendingRequest2 += SendHeaderAuth;
        }

        private void SendHeaderAuth( object sender, SendingRequest2EventArgs e )
        {
            e.RequestMessage.SetHeader( "Authorization", "Bearer " + _token );
        }

        public Default.Container Container { get; private set; }
    }
}
