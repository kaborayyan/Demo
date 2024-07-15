namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism has two parts
            // 1. Overloading
            // 2. Overriding

            // Overriding
            // Only in Classes, not supported in Structs
            // Only with inheritance
            // It uses two keywords
            // 1. new
            // 2. override
            // Check Class TypeB Code

            TypeA ObjectA = new TypeA(1);
            ObjectA.A = 10;
            ObjectA.MyFun01();
            ObjectA.MyFun02();

            Console.WriteLine("=====================");

            TypeB ObjectB = new TypeB(1,2);
            ObjectB.A = 10;
            ObjectB.B = 20;
            ObjectB.MyFun01();
            ObjectB.MyFun02();
        }
    }
}
