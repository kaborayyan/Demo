namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent P01 = new Parent(3,5);
            Console.WriteLine(P01.ToString());
            Console.WriteLine(P01.Product());

            Child C01 = new Child(4, 6, 7);
            Console.WriteLine(C01.ToString());
            Console.WriteLine(C01.Product());
        }
    }
}
