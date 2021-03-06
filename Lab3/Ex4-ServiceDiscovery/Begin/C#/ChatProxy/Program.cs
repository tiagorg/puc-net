﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Discovery;

namespace ChatProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ChatProxy Service";
            Console.WriteLine("ChatProxy Console Host");
            string hostName = Dns.GetHostName();

            using (ServiceHost proxyHost = HostDiscoveryEndpoint(hostName))
            {
                Console.WriteLine("Press <Enter> to exit");
                Console.ReadLine();
                proxyHost.Close();
            }
        }

        private static ServiceHost HostDiscoveryEndpoint(string hostName)
        {
            // Create a new ServiceHost with a singleton ChatDiscovery Proxy
            ServiceHost myProxyHost = new
                ServiceHost(new ChatDiscoveryProxy());

            string proxyAddress = "net.tcp://" +
                hostName + ":8001/discoveryproxy";

            // Create the discovery endpoint
            DiscoveryEndpoint discoveryEndpoint =
                new DiscoveryEndpoint(
                    new NetTcpBinding(),
                    new EndpointAddress(proxyAddress));

            discoveryEndpoint.IsSystemEndpoint = false;

            // Add UDP Annoucement endpoint
            myProxyHost.AddServiceEndpoint(new UdpAnnouncementEndpoint());

            // Add the discovery endpoint
            myProxyHost.AddServiceEndpoint(discoveryEndpoint);

            myProxyHost.Open();
            Console.WriteLine("Discovery Proxy {0}",
                proxyAddress);

            return myProxyHost;
        }
    }
}
