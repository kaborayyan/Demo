namespace DeepCopy_ShallowCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array of Value Type
            // In Array of value type
            int[] Array01 = { 1, 2, 3 }; // Array of value type
            int[] Array02 = new int[3];
            Console.WriteLine($"HC of Array01: {Array01.GetHashCode()}"); // 54267293
            Console.WriteLine($"HC of Array02: {Array02.GetHashCode()}"); // 18643596

            Array02 = Array01; // Shallow Copy
                               // Shallow Copy happens at Stack
                               // Two references => the same object
                               // new int[3] became unreachable object
            Console.WriteLine("After the Shallow Copy");
            Console.WriteLine($"HC of Array01: {Array01.GetHashCode()}"); // 54267293
            Console.WriteLine($"HC of Array02: {Array02.GetHashCode()}"); // 54267293

            Array02[0] = 10; // Will change the value in both arrays, they are the same thing
            Console.WriteLine($"Array01[0] = {Array01[0]}"); // 54267293
            Console.WriteLine($"Array02[0] = {Array02[0]}"); // 33574638        

            // To create two different objects with the same value
            // We have to do Deep Copy
            // It happens in the Heap
            // Using a method called Clone()
            // But it deals with objects only
            // So we have to do casting
            Array02 = (int[])Array01.Clone();
            // Now Copy done at heap level
            // Now we have two different Objects
            Array02[0] = 100;
            Console.WriteLine("After the Shallow Copy");
            Console.WriteLine($"HC of Array01: {Array01.GetHashCode()}");
            Console.WriteLine($"HC of Array02: {Array02.GetHashCode()}");

            Console.WriteLine($"Array01[0] = {Array01[0]}");
            Console.WriteLine($"Array02[0] = {Array02[0]}");

            // Microsoft says Clone causes shallow copy
            // It will be clearer when discussing array of ref values 
            #endregion
        }
    }
}
