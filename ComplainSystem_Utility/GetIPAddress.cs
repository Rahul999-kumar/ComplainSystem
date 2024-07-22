using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem_Utility
{
    public static class GetIPAddress
    {
        public static string hostName = string.Empty;
        public static string iPAddress =string.Empty;

        public static string GenerateIPAddress()
        {
            hostName = Dns.GetHostName();

            iPAddress = Dns.GetHostEntry(hostName).AddressList.Last().ToString();
            return iPAddress;
        }


    }
}
