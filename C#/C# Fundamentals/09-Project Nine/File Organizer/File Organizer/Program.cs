using System;
using System.IO;

namespace FileOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the full path of the folder to organize:");
            string folderPath = Console.ReadLine();

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file).ToLower().Trim('.');
                string targetFolder = Path.Combine(folderPath, extension + "_files");

                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                string fileName = Path.GetFileName(file);
                string destinationPath = Path.Combine(targetFolder, fileName);

                try
                {
                    File.Move(file, destinationPath);
                    Console.WriteLine($"Moved: {fileName} → {targetFolder}");
                }
                catch (IOException)
                {
                    Console.WriteLine($"File already exists: {fileName}");
                }
            }

            Console.WriteLine("File organization completed.");
        }
    }
}

