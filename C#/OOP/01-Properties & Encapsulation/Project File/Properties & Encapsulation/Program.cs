namespace Properties___Encapsulation
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Person person01 = new Person();
            Console.WriteLine("Enter your name please : ");
            String NameInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(NameInput)) // loop to make the user Enter valid name
            {
                Console.WriteLine("Name can't be empty or just spaces.");
                Console.WriteLine("Enter a valid name : ");
                NameInput = Console.ReadLine();
            }
            person01.Name = NameInput;
            Console.WriteLine("Enter your age : ");
            bool Validage = false;
            int age;
            while (Validage) // same previous 
            {
                if (int.TryParse(Console.ReadLine() , out age) && age > 0)
                {
                    person01.Age = age;
                    Validage = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }
            Console.WriteLine($"Name: {person01.Name}, Age: {person01.Age}");

        }
        public class Person
        {
            private string _name; // field
           private int _age; // field

            public string Name
            {
                get => _name;
                set => _name = value;
            }
            public int Age
            {
                get => _age;
                set => _age = value;
            }
        }
    }
}
