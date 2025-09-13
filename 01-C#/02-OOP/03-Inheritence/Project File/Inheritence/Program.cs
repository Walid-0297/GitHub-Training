namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Rex", "German Shepherd");
            myDog.Speak();
            myDog.ShowInfo();

            Console.WriteLine();

            Cat myCat = new Cat("Whiskers", "Persian");
            myCat.Speak();
            myCat.ShowInfo();
        }
    }

    // Base class
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}");
        }
    }

    // Another derived class
    public class Cat : Animal
    {
        public string Breed { get; set; }

        public Cat(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}");
        }
    }
}

