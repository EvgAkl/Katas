using System;

namespace Codewars.Katas._10
{
    class Kata12 : IKata
    {
        private static string GetReadableTime(int seconds)
        {
            var time = TimeSpan.FromSeconds(seconds);
            var result = string.Format("{0:00}:{1:00}:{2:00}", (int)time.TotalHours, time.Minutes, time.Seconds);
            return result;
        }

        public string Run()
        {
            return string.Empty.AddStringResult(GetReadableTime(0))
                               .AddStringResult(GetReadableTime(5))
                               .AddStringResult(GetReadableTime(60))
                               .AddStringResult(GetReadableTime(86399))
                               .AddStringResult(GetReadableTime(359999));
        }
    }
}
