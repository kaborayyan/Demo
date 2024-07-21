namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstraction
            // Controvery: Is it a concept or a pillar in OOP?

            Rectangle rectangle = new Rectangle(10,20);
            Console.WriteLine($"Area of rectangle is {rectangle.CalcArea()}");
            Console.WriteLine($"Perimeter of rectangle is {rectangle.Perimeter}");
            Console.WriteLine("====================");

            Circle circle = new Circle(20);
            Console.WriteLine($"Area of circle is {circle.CalcArea()}");
            Console.WriteLine($"Perimeter of circle is {circle.Perimeter}");
            Console.WriteLine("====================");

            Shape shape = new Rectangle(5,7);
            Console.WriteLine($"Area of rectangle is {shape.CalcArea()}");
            Console.WriteLine($"Perimeter of rectangle is {shape.Perimeter}");

        }
    }
}
