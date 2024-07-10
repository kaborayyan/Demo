namespace Structs
{
    // Structs are old data types
    // From the days of structural programming paradigm C++
    // Class is a reference type that supports inheritance
    // Struct is a value type that doesn't support inheritance
    // Structs support Polymorphism and overriding
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1;
            // Value type in stack
            // Uninitilaized memory
            P1.X = 10;
            P1.Y = 20;

            // easier way
            Point P2 = new Point(10,20);

            // Another way
            Point P3 = new(1,2);

            Console.WriteLine($"P1.X = {P1.X}");
            Console.WriteLine($"P2.X = {P2.X}");

            Console.WriteLine(P1); // Same as
            Console.WriteLine(P1.ToString()); // will print what it is not the values
        }
    }
}
