using System;
using Codewars.Katas;
using Codewars.Katas._10;

namespace Codewars
{
    class Program
    {
        private const int KATAS_COUNT = 16;
        private static void ShowResult(int numberOfKata, string result)
        {
            Console.WriteLine($"Kata {numberOfKata}:");
            Console.WriteLine(result);
            Console.WriteLine();
        }

        #region Custom Kata results
        private static void RunKata5()
        {
            var kata5Result = Kata5.TowerBuilder(5);
            Console.WriteLine("Kata 5:");
            foreach (var kata5 in kata5Result)
            {
                Console.WriteLine(kata5 + ",");
            }
            Console.WriteLine();
        }

        private static void RunKata14()
        {
            var kata14Result_1 = Kata14.dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });
            var kata14Result_2 = Kata14.dirReduc(new string[] { "NORTH", "WEST", "SOUTH", "EAST" });
            Console.WriteLine("Kata 14:");
            Console.WriteLine(string.Join("\t", kata14Result_1));
            Console.WriteLine(string.Join("\t", kata14Result_2));
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            for(int i = 1; i<= KATAS_COUNT; i++)
            {
                switch (i){

                    #region Custom Katas
                    case 5:
                        RunKata5();
                        break;
                    case 14:
                        RunKata14();
                        break;
                    case 16:
                        RunKata16();
                        break;
                    #endregion

                    default:
                        var kata = KataProvider.GetKata(i);
                        var result = kata.Run();
                        ShowResult(i, result);
                        break;
                }
            }
        }
    }
}
