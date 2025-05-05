namespace Calculator_App_IMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            // Read and validate the first number
            Console.WriteLine("Enter the first number: ");
            int n1;
            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Read and validate the second number
            Console.WriteLine("Enter the second number: ");
            int n2;
            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Read the operation and validate it
            Console.WriteLine("Enter the operation (+, -, *, /, %): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();  // New line after reading the operation

            do
            {
                Console.WriteLine("Enter the operation (+, -, *, /, %):");
                op = Console.ReadKey().KeyChar;
                Console.WriteLine(); // new line after key press

                if ("+-*/%".IndexOf(op) == -1)
                {
                    Console.WriteLine("Invalid operation. Please enter one of +, -, *, /, %.");
                }

            } while ("+-*/%".IndexOf(op) == -1);

            // Perform the operation
            PerformOperation(n1, n2, op);
        }
        static void PerformOperation(int n1, int n2, char op)
        {
            int result = 0;
            bool validOperation = true;

            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    else
                    {
                        result = n1 / n2;
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    else
                    {
                        result = n1 % n2;
                    }
                    break;
                default:
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"{n1} {op} {n2} = {result}");
            }
        }

    }
}
