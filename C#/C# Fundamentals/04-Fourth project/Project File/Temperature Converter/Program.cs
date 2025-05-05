namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");

            while (true)
            {
                Console.WriteLine("\nSelect conversion type:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Celsius to Kelvin");
                Console.WriteLine("3. Fahrenheit to Celsius");
                Console.WriteLine("4. Fahrenheit to Kelvin");
                Console.WriteLine("5. Kelvin to Celsius");
                Console.WriteLine("6. Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");

                Console.Write("Your choice: ");
                string input = Console.ReadLine();

                if (input == "7")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                double temp;
                Console.Write("Enter temperature value: ");
                while (!double.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Invalid input. Enter a valid number:");
                }

                switch (input)
                {
                    case "1":
                        Console.WriteLine($"Result: {CelsiusToFahrenheit(temp):F2} °F");
                        break;
                    case "2":
                        Console.WriteLine($"Result: {CelsiusToKelvin(temp):F2} K");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {FahrenheitToCelsius(temp):F2} °C");
                        break;
                    case "4":
                        Console.WriteLine($"Result: {FahrenheitToKelvin(temp):F2} K");
                        break;
                    case "5":
                        Console.WriteLine($"Result: {KelvinToCelsius(temp):F2} °C");
                        break;
                    case "6":
                        Console.WriteLine($"Result: {KelvinToFahrenheit(temp):F2} °F");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select between 1–7.");
                        break;
                }
            }
        }

        static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
        static double CelsiusToKelvin(double c) => c + 273.15;
        static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
        static double FahrenheitToKelvin(double f) => (f - 32) * 5 / 9 + 273.15;
        static double KelvinToCelsius(double k) => k - 273.15;
        static double KelvinToFahrenheit(double k) => (k - 273.15) * 9 / 5 + 32;
    }
}

