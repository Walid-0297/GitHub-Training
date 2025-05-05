using System;
using System.Text.RegularExpressions;

namespace PasswordStrengthChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            string strength = GetPasswordStrength(password);
            Console.WriteLine($"Password strength: {strength}");
        }

        static string GetPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8)
                score++;

            if (Regex.IsMatch(password, "[A-Z]"))
                score++;

            if (Regex.IsMatch(password, "[0-9]"))
                score++;

            if (Regex.IsMatch(password, "[^a-zA-Z0-9]")) // symbols
                score++;

            return score switch
            {
                0 or 1 => "Weak",
                2 or 3 => "Medium",
                4 => "Strong",
                _ => "Unknown"
            };
        }
    }
}
