namespace VehicleManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>
            {
                new Car("Toyota"),
                new Bike("Yamaha")
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.StartEngine();
                vehicle.StopEngine();
                Console.WriteLine("------------------");
            }
        }
    }

    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    public class Car : IVehicle
    {
        private string _brand;

        public Car(string brand)
        {
            _brand = brand;
        }

        public void StartEngine()
        {
            Console.WriteLine($"{_brand} car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{_brand} car engine stopped.");
        }
    }

    public class Bike : IVehicle
    {
        private string _brand;

        public Bike(string brand)
        {
            _brand = brand;
        }

        public void StartEngine()
        {
            Console.WriteLine($"{_brand} bike engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{_brand} bike engine stopped.");
        }
    }
}
