namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car Car01;
            // Create reference in stack, allocate 4 bytes for the reference
            // but 0 bytes in heap

            // Car01 = new Car();
            // 1. Allocate memory at heap ~ 16 bytes
            // 2. Allocate default values in those bytes
            // 3. Call user defined Constructors if present, if not present the compiler will generate it
            // 4. Assign the reference car01 to allocated object
            // Console.WriteLine(Car01); // Will print default values

            Car Car01 = new Car(10, "BMW", 250);
            Console.WriteLine(Car01);

            Car Car02 = new Car(20, "Nissan");
            Console.WriteLine(Car02);

            Car Car03 = new Car(30);
            Console.WriteLine(Car03);
        }
    }
}
