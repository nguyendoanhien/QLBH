using System;
using System.Net;
using System.Net.Sockets;

namespace MyUltilities
{
    public class Cart
    {
        private static Cart _cart;
        private static readonly object Padlock = new object();

        public static Cart GetCart

        {
            get
            {
                lock (Padlock)
                {
                    return _cart ?? (_cart = new Cart());
                }
            }
        }

        public static string IpAddress => GetIpAddress();

        public static string GetIpAddress()
        {
            var ipAddress = "";
            var host = default(IPHostEntry);
            string hostname = null;
            hostname = Environment.MachineName;
            host = Dns.GetHostEntry(hostname);
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    ipAddress = Convert.ToString(ip);
            return ipAddress;
        }

        public static bool IsSession(object session)

        {
            return false;
        }
    }
}