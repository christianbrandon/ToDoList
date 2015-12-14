﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using ToDoList;
using WcfService;

namespace ToDoHost
{
    class Program
    {
        static void Main()
        {
            var serviceUri = "http://localhost/ToDoService";

            WebServiceHost toDoHost = new WebServiceHost(typeof(ToDoService), new Uri(serviceUri));

            try
            {
                ServiceEndpoint toDoEndPoint = toDoHost.AddServiceEndpoint(typeof(IToDoService), new WebHttpBinding(), "");

                toDoHost.Open();

                using (ChannelFactory<IToDoService> toDoChannelFactory = new ChannelFactory<IToDoService>(new WebHttpBinding(), serviceUri))
                {
                    toDoChannelFactory.Endpoint.Behaviors.Add(new WebHttpBehavior());
                    IToDoService channel = toDoChannelFactory.CreateChannel();

                    Console.WriteLine("Up and running!");
                    Console.WriteLine("Using: {0}", toDoEndPoint.Binding.Name);
                    Console.WriteLine("Endpoint listening at: {0}", toDoEndPoint.ListenUri);
                    Console.WriteLine("{0}/todo: Gets the whole todo.", serviceUri);
                    Console.WriteLine("{0}/todo/{{name}}: Gets todolist by name", serviceUri);
                    Console.WriteLine("Press any key to kill the service...");
                    Console.ReadLine();

                    toDoHost.Close();
                }
            }
            catch (CommunicationException communicationException)
            {
                Console.WriteLine(communicationException);
                toDoHost.Abort();
            }
        }
    }
}
