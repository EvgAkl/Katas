using System.Linq;

namespace Codewars.Katas
{
    class Kata1 : IKata
    {
        private static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
        }

        public string Run()
        {
            return string.Empty.AddStringResult(DuplicateCount("abcde"))
                               .AddStringResult(DuplicateCount("aabbfgh"))
                               .AddStringResult(DuplicateCount("aabbcde"))
                               .AddStringResult(DuplicateCount("indivisibility"))
                               .AddStringResult(DuplicateCount("Indivisibilities"))
                               .AddStringResult(DuplicateCount("aA11"))
                               .AddStringResult(DuplicateCount("ABBA"));
        }

    }
}
