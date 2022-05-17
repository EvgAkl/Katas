using System.Linq;

namespace Codewars.Katas
{
    class Kata7 : IKata
    {
        private static string FirstNonRepeatingLetter(string s)
        {
            var result = s.GroupBy(char.ToLower)
                          .Where(gr => gr.Count() == 1)
                          .Select(x => x.First().ToString())
                          .DefaultIfEmpty("")
                          .First();
            return result;
        }

        public string Run()
        {
            return string.Empty.AddStringResult(FirstNonRepeatingLetter("taat"))
                               .AddStringResult(FirstNonRepeatingLetter("a"))
                               .AddStringResult(FirstNonRepeatingLetter("sTreSS"))
                               .AddStringResult(FirstNonRepeatingLetter("moonmen"));
        }
    }
}
