namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.Speak(); // Output: The animal makes a sound.
            myDog.Speak();    // Output: The dog barks.
            myCat.Speak();    // Output: The cat meows.

            Console.WriteLine();

            // Create an array of Animal objects
            Animal[] animals = new Animal[3];
            animals[0] = new Dog();
            animals[1] = new Cat();
            animals[2] = new Animal();

            foreach (Animal animal in animals)
            {
                animal.Speak(); // Runtime polymorphism
            }
        }
    }

    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }
}
