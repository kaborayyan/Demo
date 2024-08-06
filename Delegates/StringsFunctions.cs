using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // 5 Things Inside a NameSpace
    // Class
    // Struct
    // Enums
    // Interface
    // Delegates

    // Declare Delegate
    // Compiler will turn it into something similar to Class
    // Reference from Delegate can refer to Function or more (pointer to function)

    public delegate int StringFuncDelegate(string str);

    // Must have signature of Delegate returns int and accept parameter of string
    // Regardless Function name, parameters or access modifiers
    internal class StringsFunctions
    {
        // Class member methods
        public static int GetCountUpperCaseChars(string word)
        {
            int Count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        Count++;
                    }
                }
            }
            return Count;
        }

        public static int GetCountLowerCaseChars(string word)
        {
            int Count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        Count++;
                    }
                }
            }
            return Count;
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }    
}
