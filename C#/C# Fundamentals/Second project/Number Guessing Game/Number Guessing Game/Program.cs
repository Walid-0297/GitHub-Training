using System;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Random01 = new Random();
            int SecretNumber = Random01.Next(1, 100); // generates number between 1 & 100
            int guess;
            Console.WriteLine("Guess the  number between 1 & 100 : ");
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input , Enter Valid number : ");

                }
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Invalid Input , Enter number between 1 & 100 :");
                    continue; // if this condition is true -> other code lines will be ignored 
                              // it will return to the "int.Tryparse" loop  
                }
                else if (guess < SecretNumber)
                {
                    Console.WriteLine("Your guess is less than the number ");
                    Console.WriteLine("Try again :");
                }
                else if (guess > SecretNumber)
                {
                    Console.WriteLine("Your guess is more than the number ");
                    Console.WriteLine("Try again :");
                }
                else
                {
                    Console.WriteLine($"Your guess is correct , the number is {SecretNumber}");
                    break; // exit the loop 
                }
            }
        }

    } 
}
