using System.Linq;

namespace Codewars.Katas._10
{
    class Kata15 : IKata
    {
        private static string PigIt(string str)
        {
            var result = string.Join(" ", str.Split(" ").Select(x => x.Any(y => char.IsPunctuation(y)) ? x : x[1..] + x[0] + "ay"));
            return result;
        }

        public string Run()
        {
            return string.Empty.AddStringResult("'" + PigIt("Pig latin is cool") + "' ")
                               .AddStringResult("'" + PigIt("Hello world !") + "' ")
                               .AddStringResult("'" + PigIt("I love , I hate , I want") + "' ");
        }
    }
}
