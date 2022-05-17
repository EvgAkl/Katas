using System;

namespace Codewars.Katas
{
    class Kata6 : IKata
    {
        private static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10) throw new ArgumentOutOfRangeException(nameof(numbers));

            foreach(var item in numbers)
            {
                if (item < 0 || item > 9) throw new ArgumentException("Invalid array item", nameof(numbers));
            }

            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }


        public string Run()
        {
            return string.Empty.AddStringResult(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }))
                               .AddStringResult(CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }

    }
}
