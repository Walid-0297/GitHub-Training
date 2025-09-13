namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new person profile.");

            Console.Write("Enter your name (or press Enter to use default): ");
            string nameInput = Console.ReadLine();

            Console.Write("Enter your age (or press Enter to use default): ");
            string ageInput = Console.ReadLine();

            Person person;

            if (!string.IsNullOrWhiteSpace(nameInput) && int.TryParse(ageInput, out int parsedAge) && parsedAge > 0)
            {
                person = new Person(nameInput, parsedAge);
            }
            else if (!string.IsNullOrWhiteSpace(nameInput))
            {
                person = new Person(nameInput); // uses default age
            }
            else if (int.TryParse(ageInput, out parsedAge) && parsedAge > 0)
            {
                person = new Person(parsedAge); // uses default name
            }
            else
            {
                person = new Person(); // use all default values
            }

            Console.WriteLine($"\nProfile Created:");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
        }

        public class Person
        {
            // Properties
            public string Name { get; set; }
            public int Age { get; set; }

            // Default constructor
            public Person()
            {
                Name = "Unknown";
                Age = 18;
            }

            // Constructor with name
            public Person(string name)
            {
                Name = name;
                Age = 18;
            }

            // Constructor with age
            public Person(int age)
            {
                Name = "Unknown";
                Age = age;
            }

            // Full constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
