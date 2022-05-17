using System;
using Codewars.Katas._10;

namespace Codewars.Katas
{
    class KataProvider
    {
        public static IKata GetKata(int KataNumber)
        {
            IKata result = KataNumber switch
            {
                #region Katas 1-9
                1 => new Kata1(),
                2 => new Kata2(),
                3 => new Kata3(),
                4 => new Kata4(),
                // 5 Skip
                6 => new Kata6(),
                7 => new Kata7(),
                8 => new Kata8(),
                9 => new Kata9(),
                #endregion

                #region Katas 10-19
                10 => new Kata10(),
                11 => new Kata11(),
                12 => new Kata12(),
                13 => new Kata13(),
                // 14 Skip
                15 => new Kata15(),
                // 16 Skip
                #endregion

                _ => throw new ArgumentOutOfRangeException(nameof(KataNumber))
            };
            return result;
        }
    }
}
