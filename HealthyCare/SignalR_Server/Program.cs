using BussinessObject.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Server
{
    class Program
    {
        private IDisposable SignalR { get; set; }
        private string ServerURI = ConfigurationManager.ConnectionStrings["SignalRURL"].ConnectionString;

        static void Main(string[] args)
        {
            WriteToConsole("Starting server...");
            Program server = new Program();
            server.StartServer();
            Console.ReadLine();
        }

        private void StartServer()
        {
            try
            {
                SignalR = WebApp.Start<Startup>(ServerURI);
                WriteToConsole("Server started at " + ServerURI);
            }
            catch (TargetInvocationException)
            {
                WriteToConsole("Server failed to start. A server is already running on " + ServerURI);
                //Re-enable button to let user try to start server again
                return;
            }
            
        }

        internal static void WriteToConsole(String message)
        {
            Console.WriteLine(message);
        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }

    public class MyHub : Hub
    {
        static ConcurrentDictionary<string, User> _users = new ConcurrentDictionary<string, User>();

        public void PushNotification(string UserID1, string UserID2, string message)
        {
            var keys = _users.FirstOrDefault(x => x.Value.UserID == UserID2).Key;
            Program.WriteToConsole("User: " + UserID1 + "  Request notification");
            if (keys != null)
            {
                var User1 = _users.FirstOrDefault(x => x.Value.UserID == UserID1).Value;
                var User2 = _users.FirstOrDefault(x => x.Value.UserID == UserID2).Value;
                Clients.Client(keys.ToString()).addMessage(User1, User2, message);
                Program.WriteToConsole("User: " + User1.UserID + "  Notification: to " + keys.ToString() + "  " + User2.UserID + "  " + message);
            }
        }

        public void SetUser(User user)
        {
            _users[Context.ConnectionId] = user;
            Console.WriteLine("Set " + Context.ConnectionId + " with UserID: " + _users[Context.ConnectionId].UserID + " - Full Name: " + _users[Context.ConnectionId].FullName);
        }

        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }

        public override Task OnConnected()
        {
            Program.WriteToConsole("Client connected: " + Context.ConnectionId);
            _users.TryAdd(Context.ConnectionId, null);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            if (stopCalled)
            {
                // We know that Stop() was called on the client,
                // and the connection shut down gracefully.
            }
            else
            {
                // This server hasn't heard from the client in the last ~35 seconds.
                // If SignalR is behind a load balancer with scaleout configured, 
                // the client may still be connected to another SignalR server.
            }
            User user;
            _users.TryRemove(Context.ConnectionId, out user);
            Program.WriteToConsole("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }

        private void abc()
        {
        }
    }
}
