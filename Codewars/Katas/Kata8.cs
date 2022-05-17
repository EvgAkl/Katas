using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    class Kata8 : IKata
    {
        private static long QueueTime(int[] customers, int n)
        {
            var queues = new List<int>(Enumerable.Repeat(0, n));
            foreach(var currentCustomer in customers)
            {
                queues[queues.IndexOf(queues.Min())] += currentCustomer;
            }
            return queues.Max();
        }

        public string Run()
        {
            return string.Empty.AddStringResult(QueueTime(new int[] { 5, 3, 4 }, 1))
                               .AddStringResult(QueueTime(new int[] { 10, 2, 3, 3 }, 2))
                               .AddStringResult(QueueTime(new int[] { 2, 3, 10 }, 2));
        }
    }
}
