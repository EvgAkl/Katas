using System;
using System.Linq;

namespace Codewars.Katas._10
{
    class Kata10 : IKata
    {
        private static string ToCamelCase(string str)
        {
            string separator;
            if (str.Contains("-"))
            {
                separator = "-";
            }
            else if (str.Contains("_"))
            {
                separator = "_";
            }
            else
            {
                throw new ArgumentException("Invalid separator", nameof(str));
            }

            var result = str.Split(separator).Aggregate((x, y) => x + new string(y.Substring(1).ToCharArray().Prepend(char.ToUpper(y.First())).ToArray()));
            return result;
        }


        public string Run()
        {
            return string.Empty.AddStringResult(ToCamelCase("the_stealth_warrior"))
                               .AddStringResult(ToCamelCase("The_Stealth_Warrior"))
                               .AddStringResult(ToCamelCase("hropixnqar_dgqfteoapmNkpvfwhscl"));
        }
    }
}
