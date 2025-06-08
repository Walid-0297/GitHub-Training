using System;
using System.Collections.Generic;
using System.IO;

namespace To_Do_List
{
    internal class Program
    {
        static string filePath = "tasks.txt";
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            LoadTasksFromFile();

            while (true)
            {
                Console.WriteLine("\n--- To-Do List ---");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1–4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        SaveTasksToFile();
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select between 1 and 4.");
                        break;
                }
            }
        }
        static void LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                tasks = new List<string>(File.ReadAllLines(filePath));
            }
        }

        static void SaveTasksToFile()
        {
            File.WriteAllLines(filePath, tasks);
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            Console.WriteLine("\nTasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void AddTask()
        {
            Console.Write("Enter a new task: ");
            string task = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Cannot add an empty task.");
            }
        }

        static void RemoveTask()
        {
            ViewTasks();

            if (tasks.Count == 0)
                return;

            Console.Write("Enter the task number to remove: ");
            int index;

            while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > tasks.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid task number:");
            }

            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task removed.");
        }
    }  
}
