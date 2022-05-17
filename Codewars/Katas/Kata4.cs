using System.Linq;

namespace Codewars.Katas
{
    class Kata4 : IKata
    {
        private static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }

        public string Run()
        {
            return string.Empty.AddStringResult(OddOrEven(new int[] { 0 }))
                               .AddStringResult(OddOrEven(new int[] { 0, 1, 4 }))
                               .AddStringResult(OddOrEven(new int[] { 0, -1, -5 }));
        }
    }
}
