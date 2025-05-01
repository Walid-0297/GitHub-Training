using System;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // generates number between 1 and 100

            int guess;

            Console.WriteLine("Guess a number between 1 and 100:");

            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number:");
                }

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                    continue;
                }

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low. Try again:");
                    Console.WriteLine("");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high. Try again:");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number.");
                    break;
                }
            }
        }

    } 
}
