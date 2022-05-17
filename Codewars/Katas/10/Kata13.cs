using System.Net;

namespace Codewars.Katas._10
{
    class Kata13 : IKata
    {
        private static long IpsConvert(string str)
        {
            var result = (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(str).Address);
            return result;
        }


        private static long IpsBetween(string start, string end)
        {
            var result = IpsConvert(end) - IpsConvert(start);
            return result;
        }


        public string Run()
        {
            return string.Empty.AddStringResult(IpsBetween("10.0.0.0", "10.0.0.50"))
                               .AddStringResult(IpsBetween("10.0.0.0", "10.0.1.0"))
                               .AddStringResult(IpsBetween("20.0.0.10", "20.0.1.0"));
        }
    }
}
