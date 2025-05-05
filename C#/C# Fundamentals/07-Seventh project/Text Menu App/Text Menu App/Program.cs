using System;

namespace Text_Menu_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Main Menu ===");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Current Date");
                Console.WriteLine("3. Show Random Number");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Hello, user!");
                        break;

                    case "2":
                        Console.WriteLine("Today's date is: " + DateTime.Now.ToShortDateString());
                        break;

                    case "3":
                        Random random = new Random();
                        Console.WriteLine("Random number: " + random.Next(1, 101));
                        break;

                    case "4":
                        Console.WriteLine("Exiting the program...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}
