using System.Text;

namespace DeepCopy_ShallowCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array of Value Type
            // In Array of value type
            // Remember any Object has two parts
            // An Identity = Address
            // Object State = Data
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
            // It creates different new object but with same Object state "Data" as the Caller 
            // But it deals with objects only
            // So we have to do casting
            Array02 = (int[])Array01.Clone();
            // Now Copy done at heap level
            // Now we have two different Objects
            Array02[0] = 100;
            Console.WriteLine("After the Shallow Copy");
            Console.WriteLine($"HC of Array01: {Array01.GetHashCode()}");
            Console.WriteLine($"HC of Array02: {Array02.GetHashCode()}");

            Console.WriteLine($"Array01[0] = {Array01[0]}"); // 10
            Console.WriteLine($"Array02[0] = {Array02[0]}"); // 100

            // Microsoft says Clone causes shallow copy
            // It will be clearer when discussing array of ref values 
            #endregion

            #region Array of Reference Type: string "Immutable"
            // Array of reference type
            // Array of string = immutable
            // It's the same with Shallow Copy
            string[] Names01 = /*new string[]*/ { "Karim", "Fayez" };
            string[] Names02 = new string[2];

            Console.WriteLine($"The HC of Names01: {Names01.GetHashCode()}"); // 33736294
            Console.WriteLine($"The HC of Names02: {Names02.GetHashCode()}"); // 35191196

            Names02 = Names01; // Shallow Copy => equal references in stack => same object
            Console.WriteLine($"Names01[0]: {Names01[0]}");
            Console.WriteLine($"Names02[0]: {Names02[0]}");
            Console.WriteLine("After Shallow Copy");
            Console.WriteLine($"The HC of Names01: {Names01.GetHashCode()}"); // 33736294
            Console.WriteLine($"The HC of Names02: {Names02.GetHashCode()}"); // 33736294

            Names02[0] = "Aya";
            Console.WriteLine($"Names01[0]: {Names01[0]}");
            Console.WriteLine($"Names02[0]: {Names02[0]}");

            // Doing Deep Copy: Using Clone
            Names02 = (string[])Names01.Clone();
            // It creates different new object but with same Object state "Data" as the Caller 
            // But it deals with objects only, so we have to do casting
            // Video is important
            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"The HC of Names01: {Names01.GetHashCode()}"); // 33736294
            Console.WriteLine($"The HC of Names02: {Names02.GetHashCode()}"); // 48285313

            Names02[0] = "Yasmine";
            Console.WriteLine($"Names01[0]: {Names01[0]}");
            Console.WriteLine($"Names02[0]: {Names02[0]}");

            #endregion

            #region Array of Reference Type: StringBuilder "Mutable"
            StringBuilder[] Name01 = new StringBuilder[1];
            Name01[0] = new StringBuilder("Karim");

            StringBuilder[] Name02 = new StringBuilder[1];

            Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}"); // 31914638
            Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}"); //18796293

            // Shallow Copy
            Name02 = Name01;
            Console.WriteLine("After the Shallow Copy");
            Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}"); // 31914638
            Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}"); // 31914638

            Console.WriteLine($"Name01[0] = {Name01[0]}");
            Console.WriteLine($"Name02[0] = {Name02[0]}");

            Name02[0].Append(" Mohammed");
            Console.WriteLine("After the Append");
            Console.WriteLine($"Name01[0] = {Name01[0]}");
            Console.WriteLine($"Name02[0] = {Name02[0]}");

            Console.WriteLine("After the Deep Copy");
            Name02 = (StringBuilder[])Name01.Clone();
            Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}"); // 31914638
            Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}"); // 34948909

            Name02[0].Append(" Abourayan");
            Console.WriteLine("After the Append");
            Console.WriteLine($"Name01[0] = {Name01[0]}"); // Karim Mohammed Abourayan
            Console.WriteLine($"Name02[0] = {Name02[0]}"); // Karim Mohammed Abourayan

            // Why this happened?
            // See the video for more details
            // On Stack level Clone() is doing deep copy
            // On Heap level it's only creating new Object but with the same data inside it
            // The data here are the reference to the StringBuilder
            // So now we have two different object but both are referring to the same StringBuilder
            // The StringBuilder is mutable so it will change directly
            #endregion
        }
    }
}
