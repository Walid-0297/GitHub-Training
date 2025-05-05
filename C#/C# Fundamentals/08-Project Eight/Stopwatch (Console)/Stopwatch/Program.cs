using System;
using System.Diagnostics;

namespace StopwatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Console Stopwatch");
            Console.WriteLine("Type 'start' to begin, 'stop' to end, 'exit' to quit.");

            while (true)
            {
                Console.Write("\nCommand: ");
                string input = Console.ReadLine()?.ToLower();

                switch (input)
                {
                    case "start":
                        if (!stopwatch.IsRunning)
                        {
                            stopwatch.Start();
                            Console.WriteLine("Stopwatch started...");
                        }
                        else
                        {
                            Console.WriteLine("Stopwatch is already running.");
                        }
                        break;

                    case "stop":
                        if (stopwatch.IsRunning)
                        {
                            stopwatch.Stop();
                            Console.WriteLine($"Stopwatch stopped. Elapsed time: {stopwatch.Elapsed}");
                            stopwatch.Reset();
                        }
                        else
                        {
                            Console.WriteLine("Stopwatch is not running.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid command. Type 'start', 'stop', or 'exit'.");
                        break;
                }
            }
        }
    }
}

