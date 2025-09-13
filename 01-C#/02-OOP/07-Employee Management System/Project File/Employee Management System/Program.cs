namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Manager("Ali", 1001, 20000, 5),
                new Developer("Sara", 1002, 15000, "C#"),
                new Developer("Kareem", 1003, 16000, "Python")
            };

            foreach (var emp in employees)
            {
                emp.DisplayInfo();
                Console.WriteLine("------------------------");
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {ID}, Salary: {Salary}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }

    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int id, double salary, string language)
            : base(name, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
    }
}
