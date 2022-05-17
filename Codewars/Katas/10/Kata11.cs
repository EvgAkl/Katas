using System.Linq;

namespace Codewars.Katas._10
{
    class Kata11 : IKata
    {
        private static int[] MoveZeroes(int[] arr)
        {
            var result = arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
            return result;
        }

        public string Run()
        {
            var array = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            var result = string.Empty;
            foreach(int item in array)
            {
                result += string.Empty.AddStringResult(item);
            }
            return result;
        }
    }
}
