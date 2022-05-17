namespace Codewars.Katas
{
    class Kata5
    {
        public static string[] TowerBuilder(int nFloors)
        {
            var result = new string[nFloors];
            for (int i = 0; i < nFloors; i++)
            {
                var spaceCount = nFloors - i - 1;
                result[i] = new string(' ', spaceCount) + new string('*', i * 2 + 1) + new string(' ', spaceCount);
            }   
            return result;
        }

    }
}
