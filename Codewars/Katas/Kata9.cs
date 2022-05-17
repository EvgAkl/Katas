using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    class Kata9 :IKata
    {
        private static string High(string s)
        {
            var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
            var score = new Dictionary<char, int>();
            var iterator = 0;
            foreach(var item in alphabet)
            {
                score.Add(alphabet[iterator], iterator + 1);
                iterator++;
            }

            var result = s.Split(" ")
                          .Distinct()
                          .ToDictionary(x => x, x => x.ToCharArray().Sum(x => score.First(y => y.Key == x).Value))
                          .OrderByDescending(x => x.Value)
                          .First().Key;

            return result;
        }

        public string Run()
        {
            return string.Empty.AddStringResult(High("man i need a taxi up to ubud"))
                               .AddStringResult(High("what time are we climbing up to the volcano"))
                               .AddStringResult(High("take me to semynak"))
                               .AddStringResult(High("aa b"));
        }
    }
}
