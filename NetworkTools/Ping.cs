using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkTools
{
    public static class SendPing
    {
        public static async Task<long> Ping(string url)
        {
            return (await new Ping().SendPingAsync(url)).RoundtripTime;
        }

        public static async Task<long> Ping(IPAddress ip)
        {
            return (await new Ping().SendPingAsync(ip)).RoundtripTime;
        }

        public static async Task<long> Ping(string url, int timeout)
        {
            return (await new Ping().SendPingAsync(url, timeout)).RoundtripTime;
        }

        public static async Task<long> Ping(IPAddress ip, int timeout)
        {
            return (await new Ping().SendPingAsync(ip, timeout)).RoundtripTime;
        }
    }
}
