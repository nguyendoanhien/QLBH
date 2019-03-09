using System;
using System.Net;
namespace MyUltilities
{
    public class Cart
    {
        private static string ipAddress;
        private static Cart cart;
        private static string cartSession;
        private static readonly object padlock = new object();
        public static Cart GetCart

        {
            get
            {
                lock (padlock)
                {
                    if (cart == null)
                    {
                        cart = new Cart();
                    }
                    return cart;
                }
            }
        }
        public static string IpAddress

        {
            get
            {
                return GetIpAddress();
            }
        }
        public static bool IsSession(object session)

        {
            if (String.IsNullOrEmpty(session.ToString()))
                return false;
            return true;
        }
        public static string GetIpAddress()
        {
            string IPAddress="";
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }
       
     

    }
}
