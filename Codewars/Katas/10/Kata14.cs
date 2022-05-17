using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas._10
{
    class Kata14
    {
        public static string[] dirReduc(string[] arr)
        {
            var dictionary = new Dictionary<string, int>()
            {
                {"NORTH", 1},
                {"SOUTH", 3},
                {"WEST", 2},
                {"EAST", 4}
            };
            var list = arr.Select(x => dictionary.First(y => y.Key == x).Value).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (i == list.Count - 1) break;

                var isRemove = (list[i] != list[i + 1]) && ((list[i] + list[i + 1]) % 2 == 0);
                if (isRemove)
                {
                    list.RemoveRange(i, 2);
                    i = -1;
                }
            }
            var result = list.Select(x => dictionary.First(y => y.Value == x).Key).ToArray();
            return result;
        }
    }
}
