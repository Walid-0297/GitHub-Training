namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create list to store students
            List<Student> students = new List<Student>();

            // Input: Number of students
            Console.Write("Enter number of students to add: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nStudent #{i + 1}");

                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter student ID: ");
                string id = Console.ReadLine();

                // Create student object using constructor
                Student student = new Student(name, id);

                // Add student to the list
                students.Add(student);
            }

            // Display all students
            Console.WriteLine("\nList of Students:");
            foreach (Student s in students)
            {
                Console.WriteLine($"Name: {s.Name}, ID: {s.ID}");
            }
        }
    }

    // Class representing a student
    public class Student
    {
        // Properties
        public string Name { get; set; }
        public string ID { get; set; }

        // Constructor
        public Student(string name, string id)
        {
            Name = name;
            ID = id;
        }
    }
}
