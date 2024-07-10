namespace Boxing_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Casting from Value type to Reference type "Boxing"
            // Casting from Reference type to Value type "Unboxing"
            object Object01;
            Object01 = "Karim"; // Casting (Reference to Reference)
            
            Object01 = 40;
            // Casting (Value to Reference "from Rt to Lt") => Boxing
            // Safe Casting

            // The opposite is not possible
            // int X = Object01; => invalid
            // The correct way is:
            int X = (int)Object01;
            // Casting (Reference to Value) Unboxing
            // Unsafe casting

            // Boxing and Unboxing were useful
            // in the old days before Generics
            // Try to avoid them as possible
            // They decrease performance and consume memory

        }
    }
}
