using System.Xml.Linq;

namespace Overloading
{
    internal class Program
    {
        // Polymorphism
        // 1. Overloading (Same Constructors Name but different Parameters)
        // 2. Overriding (in Classes only since it needs Inheritance)

        #region Overloading
        // Method - Constructor Overloading
        // Supported in both Classes and Structs
        // Parameters must differ in order, count, type or all
        // Which copy is used is determined when you pass the arguments
        // Method overloading is for readability only

        // The next example is not the best example
        public static int Sum(int X, int Y)
        {
            return X + Y;
        }

        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }

        public static double Sum(double X, double Y)
        {
            return X + Y;
        }

        public static double Sum(int X, double Y)
        {
            return X + Y;
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1,2));
            
            // Example: Console.WriteLine has 18 overloads 
        }
    }
}
