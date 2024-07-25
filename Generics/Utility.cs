using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Utility<T> where T : /*class? struct enums*/ IComparable<T>
    {
        // A struct or class that uses generics must implement the interface IComparable
        // To be able to use CompareTo()
        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k].CompareTo(array[k + 1])==1)
                        {
                            Helper<T>.SWAP(ref array[k], ref array[k+1]);
                        }
                    }
                }
            }
        }
    }
}
