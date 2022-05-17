namespace Codewars.Katas
{
    class Kata3 : IKata
    {
        private static string GetMiddle(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var length = s.Length;
            return length % 2 == 0 ? s.Substring(length / 2 - 1, 2) : s.Substring(length / 2, 1);
        }

        public string Run()
        {
            return string.Empty.AddStringResult(GetMiddle("test"))
                               .AddStringResult(GetMiddle("testing"))
                               .AddStringResult(GetMiddle("middle"))
                               .AddStringResult(GetMiddle("A"));
        }
    }
}
