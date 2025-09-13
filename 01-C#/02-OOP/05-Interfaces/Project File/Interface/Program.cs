namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle(5, 10);
            IShape circle = new Circle(7);

            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            DisplayShapeInfo(rectangle);
            DisplayShapeInfo(circle);
        }

        static void DisplayShapeInfo(IShape shape)
        {
            Console.WriteLine("Displaying shape information:");
            shape.Draw();
        }
    }

    public interface IShape
    {
        double CalculateArea();
        void Draw();
    }

    public class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
}
