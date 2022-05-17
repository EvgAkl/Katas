using System.Text.RegularExpressions;

namespace Codewars.Katas
{
    class Kata2 : IKata
    {
        private static bool ValidatePin(string pin)
        {
            return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
        }

        public string Run()
        {
            return string.Empty.AddStringResult(ValidatePin("1234"))
                               .AddStringResult(ValidatePin("12345"))
                               .AddStringResult(ValidatePin("a234"))
                               .AddStringResult(ValidatePin("123456"))
                               .AddStringResult(ValidatePin("1a3bc6"));
        }

    }
}
