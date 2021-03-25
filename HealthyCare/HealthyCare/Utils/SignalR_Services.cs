using BussinessObject.Entities;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCare.Utils
{
    public class SignalR_Services
    {
        private static IHubProxy MyHubProxy { get; set; }

        private static string ServerURI = ConfigurationManager.ConnectionStrings["SignalRURL"].ConnectionString;

        private static HubConnection Connection { get; set; }
        private static SignalR_Services instance = null;

        private SignalR_Services(User user)
        {
            //Task.Run(() => ConnectAsync());
            ConnectAsync(user);
        }

        public static SignalR_Services getInstance(User user)
        {
            if (instance == null)
            {
                instance = new SignalR_Services(user);
            }
            return instance;
        }

        public static IHubProxy HubProxy
        {
            get
            {
                return MyHubProxy;
            }
        }

        public static void CloseConnection()
        {
            if (Connection != null)
            {
                Connection.Stop(new TimeSpan(1000));
                Connection.Dispose();
                Connection = null;
                instance = null;
            }
        }

        private async void ConnectAsync(User user)
        {
            Connection = new HubConnection(ServerURI);
            Connection.Closed += Connection_Closed;
            MyHubProxy = Connection.CreateHubProxy("MyHub");
            //Handle incoming event from server: use Invoke to write to console from SignalR's thread
            
            try
            {
                await Connection.Start();
                await HubProxy.Invoke("SetUser", LoginInfo.user);
            }
            catch (HttpRequestException)
            {
                //No connection: Don't enable Send button or show chat UI
                Console.WriteLine("Cannot connect to server");
                return;
            }

            //Activate UI
            Console.WriteLine("Connected to server at " + ServerURI);
            
        }

        private static void Connection_Closed()
        {

        }
    }
}
