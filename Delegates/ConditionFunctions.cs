using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ConditionFunctions
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool DividableByThree(int X) { return X % 3 == 0; }
        public static bool CheckLength(string S) { return S.Length > 3; }
        public static void Welcome() { Console.WriteLine("Hello, there!"); }
        public static void Welcome02(string S) { Console.WriteLine($"Hello, {S}!"); }
    }
}
