namespace Codewars.Katas
{
    public static class Helpers
    {
        public static string AddStringResult<T>(this string str, T value)
        {
            return str += value.ToString() + "\t";
        }
    }
}
