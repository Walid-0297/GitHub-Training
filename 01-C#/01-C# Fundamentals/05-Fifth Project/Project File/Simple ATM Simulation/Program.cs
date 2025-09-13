using System;

namespace Simple_ATM_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;
            decimal balance = 1000;
            int attempts = 0;
            bool isAuthenticated = false;

            // PIN Verification
            while (attempts < 3)
            {
                Console.Write("Enter your 4-digit PIN: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int enteredPin) && enteredPin == pin)
                {
                    isAuthenticated = true;
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Incorrect PIN. Try again.");
                }
            }

            if (!isAuthenticated)
            {
                Console.WriteLine("Too many failed attempts. Card blocked.");
                return;
            }

            // Main ATM Menu
            while (true)
            {
                Console.WriteLine("\nWelcome to Simple ATM");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Your current balance is: ${balance}");
                        break;

                    case "2":
                        Console.Write("Enter amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"Deposited ${depositAmount}. New balance: ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Withdrawn ${withdrawAmount}. New balance: ${balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Thank you for using Simple ATM. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose from 1 to 4.");
                        break;
                }
            }
        }
    }
}
