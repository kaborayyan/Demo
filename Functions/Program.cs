namespace Functions
{
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enums
    internal class Program
    {
        public static void PrintName(int Counter = 5, string Name = "Hello!") // Passing Default Values
        {
            for (int i = 0; i < Counter; i++)
                Console.WriteLine(Name);
            // static: we will call it directly without any objects
            // void: does not return anything
            // If passing a single default value, it MUST BE the last one
        }

        public static void SwapValueByValue(int FirstNumber, int SecondNumber)
        {
            int Temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = Temp;
        }

        public static void SwapValueByRef(ref int FirstNumber, ref int SecondNumber)
        {
            int Temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = Temp;
        }

        public static int SumArrayByValue(int[] Numbers)
        {
            int Sum = 0;
            Numbers = new int[] {40, 50,60 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                Sum += Numbers[i];
            }
            return Sum;
        }

        public static int SumArrayByRef(ref int[] Numbers)
        {
            int Sum = 0;
            Numbers = new int[] { 40, 50, 60 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                Sum += Numbers[i];
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            #region Functions
            // Functions

            // Prototype            Calling
            // 1. Return Type       1. Name
            // 2. Name              2. Arguments
            // 3. Parameters
            // 4. Body

            // (Return Type + Name + Parameters) => Signature
            // Functions must be included in a Class

            // Functions are two types
            // 1. Class member function = Static = doesn't require an Object to act
            // 2. Object member function = Non-Static = needs an object to act

            // Program.PrintName(); // if in a different class
            
            PrintName(7,"Karim");
            PrintName(Name: "Fayez", Counter: 8); // different order
            PrintName(Name: "Kobesy"); // One argument only

            #endregion

            #region Passing Value Type Parameters

            // Passing Value Type Parameters By Value
            // It won't affect the original Variables since we are passing their value only
            int X = 10;
            int Y = 20;
            
            SwapValueByValue(X, Y);            
            Console.WriteLine(X); //10
            Console.WriteLine(Y); //20

            // Passing Value Type Parameters By Reference
            // It will affect the original Variables
            // Since we are passing the variables themselves
            // The Parameters are both input and output
            SwapValueByRef(ref X, ref Y);            
            Console.WriteLine(X); //20
            Console.WriteLine(Y); //10
            #endregion

            #region Passing Refrence Type Parameters
            // On passing them by value, we've created two addresses to the same information in the heap
            int[] Ages = { 10, 20, 30 };
            Console.WriteLine(SumArrayByValue(Ages)); //150
            Console.WriteLine(Ages[0]); //10

            // On passing them by reference, we're changing the object itself.
            int[] Salaries = { 1000, 1500, 1500 };
            Console.WriteLine(SumArrayByRef(ref Salaries)); //150
            Console.WriteLine(Salaries[0]); //40
            #endregion

        }
    }
}
