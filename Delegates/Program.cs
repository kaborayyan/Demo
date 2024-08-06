using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        static List<int> FindOddNumbers(List<int> list)
        {
            List<int> Result = new List<int>();
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        Result.Add(list[i]);
                    }
                }
            }
            return Result;
        }

        public delegate bool ConditionDelegate01(int A);
        public delegate bool ConditionDelegate02(string S);
        public delegate bool ConditionDelegate<T>(T X);
        // This Delegate looks like the functions in ConditionFunctions Class
        // You can add as many functions in ConditionFunctions
        // Without repeating the code every time in FindNumbers Function 

        #region EX03 The Classic Way
        static List<int> FindNumbers(List<int> list, ConditionDelegate01 reference)
        {
            List<int> Result = new List<int>();
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        Result.Add(list[i]);
                    }
                }
            }
            return Result;
        }

        static List<string> FindStrings(List<string> list, ConditionDelegate02 reference)
        {
            List<string> Result = new List<string>();
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        Result.Add(list[i]);
                    }
                }
            }
            return Result;
        }
        #endregion

        #region EX03 with Delegates & Generics
        static List<T> FindElements<T>(List<T> list, ConditionDelegate<T> reference) // You can use Predicate here
        {
            List<T> Result = new List<T>();
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        Result.Add(list[i]);
                    }
                }
            }
            return Result;
        }
        #endregion

        #region Functions Returning Functions
        static Action Function01()
        {
            // Action action = delegate () { Console.WriteLine("Hello, there!"); };
            // Action action = () => { Console.WriteLine("Hello, there!"); };
            // Action action = () => Console.WriteLine("Hello, there!");
            
            // return actions;

            return () => Console.WriteLine("Hello, there!");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Delegates
            // Delegates

            // C# is mainly an OOP language
            // With delegates you can do
            // Functional Programming
            // Event-driven Programming

            // Java for example is pure OOP
            // For functional programming, you need strategy design pattern
            // For event driven programming, you need observer design pattern

            // Functional Programming means
            // 1. Function into variable
            // 2. Function into function
            // 3. Function return function
            #endregion

            #region EX01
            // Reference from Delegate can refer to Function or more (pointer to function)
            // Must have signature of Delegate returns int and accept parameter of string
            // Regardless Function name, parameters or access modifiers
            // The original form is
            // StringFuncDelegate X = new StringFuncDelegate(StringsFunctions.GetCountUpperCaseChars);
            // The syntax sugar is
            StringFuncDelegate X = StringsFunctions.GetCountUpperCaseChars;
            // Declare reference from type StringFuncDelegate
            // variable carrying the address of a function
            X += StringsFunctions.GetCountLowerCaseChars;
            // X += StringFunctions.Print; // Invalid not following the signature

            // Use the function through the reference
            int Result = X("Hello, World");
            // int Result = X.Invoke(str: "Hello, World");
            // X is like an object
            // X will invoke the two functions
            // But result will carry the value of the last function
            Console.WriteLine(Result);
            #endregion

            #region EX02
            int[] Numbers01 = { 9, 8, 7, 6, 5, 1, 2, 3, 4 };

            SortingAlgorithms.BubbleSortAscending(Numbers01);
            foreach (int number in Numbers01)
            {
                Console.Write($"{number} "); // 1 2 ... 9
            }
            Console.WriteLine();

            // Using the Delegate
            ConditionFuncDelegate reference01 = SortingFunctions.SortAscending;
            // use any of the next lines
            // Both are correct
            SortingAlgorithms.BubbleSort01(Numbers01, reference01);
            SortingAlgorithms.BubbleSort01(Numbers01, SortingFunctions.SortAscending);
            foreach (int number in Numbers01)
            {
                Console.Write($"{number} "); // 1 2 ... 9
            }
            Console.WriteLine();

            ConditionFuncDelegate reference02 = SortingFunctions.SortDescending;
            // Use any of the next lines
            // Both are correct
            SortingAlgorithms.BubbleSort01(Numbers01, reference02);
            SortingAlgorithms.BubbleSort01(Numbers01, SortingFunctions.SortDescending);
            foreach (int number in Numbers01)
            {
                Console.Write($"{number} "); // 9 8 ... 1
            }
            Console.WriteLine();

            string[] Names01 = { "Ahmed", "Mahmoud", "Ali", "Mariam", "Aya", "Omar" };
            SortingAlgorithms.BubbleSort02(Names01, SortingFunctions.SortAscending);
            foreach (string name in Names01)
            {
                Console.Write($"{name} "); // Ali Aya Omar Ahmed Mariam Mahmoud
            }
            Console.WriteLine();

            SortingAlgorithms.BubbleSort02(Names01, SortingFunctions.SortDescending);
            foreach (string name in Names01)
            {
                Console.Write($"{name} "); // Mahmoud Mariam Ahmed Omar Ali Aya
            }
            Console.WriteLine();
            #endregion

            #region EX03
            List<int> Numbers02 = Enumerable.Range(1, 100).ToList(); // To create list
            List<int> OddNumbers = FindOddNumbers(Numbers02);
            foreach (int number in OddNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            // With Delegates
            List<int> OddNumbers01 = FindNumbers(Numbers02, ConditionFunctions.CheckOdd);
            foreach (int number in OddNumbers01)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            List<int> EvenNumbers01 = FindNumbers(Numbers02, ConditionFunctions.CheckEven);
            foreach (int number in EvenNumbers01)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            List<int> DividableByThree = FindNumbers(Numbers02, ConditionFunctions.DividableByThree);
            foreach (int number in DividableByThree)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            List<string> Names02 = new List<string> { "Ahmed", "Mahmoud", "Aya", "Mariam", "Ali", "Omar" };

            List<string> LongNames01 = FindStrings(Names02, ConditionFunctions.CheckLength);
            foreach (string name in LongNames01)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();

            List<string> LongNames02 = FindElements(Names02, ConditionFunctions.CheckLength);
            foreach (string name in LongNames01)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();

            List<int> DividableBy3 = FindElements(Numbers02, ConditionFunctions.DividableByThree);
            foreach (int number in DividableByThree)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            #endregion

            #region Built-In Delegates
            // Built in Delegates
            // watch this video carefully
            // No need to create your own Delegates
            // C# has its own ready to use Delegates
            // 3 types
            // Predicate Action Func

            // Predicate
            // Accepts only one parameter of any data type "Generic" and always returns boolean
            Predicate<int> predicate01 = ConditionFunctions.CheckOdd;
            // It can replace ConditionDelegate01 and ConditionDelegate02

            // Func
            // You can decide both the data types of input and output
            // It can accept up to 16 input parameter
            Func<int, bool> func01 = ConditionFunctions.CheckOdd; // input: int, output: bool
            Func<string, string, bool> func02 = SortingFunctions.SortAscending;
            // Input: 2 both string, Output: bool

            // Action
            // No return type in other words Void
            // No input parameters also
            Action action01 = ConditionFunctions.Welcome;
            action01.Invoke();
            // If you need an input parameter
            // There's a Generic version of it
            Action<string> action02 = ConditionFunctions.Welcome02;
            action02("Karim"); // Just like action02.Invoke("Karim");

            #endregion

            #region Anonymous
            // Anonymous Method
            // Predicate<int> predicate02 = ConditionFunctions.CheckOdd;
            // Instead of this we can copy the method directly
            // Predicate<int> predicate02 = public static bool CheckOdd(int X) { return X % 2 != 0; }
            // We don't need public or static since we are not in a class
            // We don't need bool, Predicate always return bool
            // We don't need a name for the method, it's anonymous
            // We need to add delegate
            Predicate<int> predicate02 = delegate (int X) { return X % 2 != 0; };
            // To use it either
            predicate02.Invoke(5);
            // or
            predicate02(5);
            #endregion

            #region Lambda Expression
            // Predicate<int> predicate02 = delegate (int X) { return X % 2 != 0; };
            // Remove delegate
            // Add fat arrow. It's read as "goes to"
            // Predicate<int> predicate03 = (int X) => { return X % 2 != 0; }; // Valid
            // Remove the int. We already know this from Predicate<int>
            // Predicate<int> predicate03 = X => { return X % 2 != 0; }; // Valid
            // Remove return and the curly braces
            Predicate<int> predicate03 = X => X % 2 != 0; // Lambda Expression
            #endregion

            #region var
            // var
            // Implicit type local variable
            // When you declare a variable using var, you must assign it to a value immediately
            // So that the compiler will identify the data type
            var predicate04 = ConditionFunctions.CheckEven;
            #endregion


        }
    }
}
