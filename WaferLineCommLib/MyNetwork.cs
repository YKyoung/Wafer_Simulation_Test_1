using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineCommLib
{
    public class MyNetwork
    {
        public static List<IPAddress> Addresses
        {
            get
            {
                List<IPAddress> addresses = new List<IPAddress>();
                string name = Dns.GetHostName();
                IPHostEntry iphe = Dns.GetHostEntry(name);
                foreach (IPAddress addr in iphe.AddressList)
                {
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        addresses.Add(addr);
                    }
                }
                return addresses;
            }
        }
    }
}
