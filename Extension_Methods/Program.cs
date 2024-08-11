namespace Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Extension Methods
            
            // Method: Reverse int Number
            int Number = 12345; // no built in way to reverse it to 54321
                                // int is a built in struct

            int Result01 = intExtensions.Reverse(12345);
            Console.WriteLine(Result01);

            int Result02 = Number.Reverse();
            intExtensions.Reverse(12345);

        }
    }
}
