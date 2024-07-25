using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Helper<T> // you write it if you need generic property
    {
        // Generic Way
        // T => Generic Type
        // If you define the generic type on "class - struct - interface" level, you will need to identify on calling the class
        // You will need to identify it on class level if you need to use generic on a property
        
        // SWAP => Generic Method
        // If you define the Generic Type on Method level, no need to identify it on call since the compiler will identify it

        public static void SWAP/*<T>*/(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int SearchArray(T[] array, T value)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Equals(array[i])) // you can't use == with generics
                        return i;
                }
            }
            return -1;
        }
    }
}
