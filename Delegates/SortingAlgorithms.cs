using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Declaring the Delegate
    public delegate bool ConditionFuncDelegate(int A, int B);

    public delegate bool ConditionFuncDelegate<T>(T A, T B); // With Generics
    internal class SortingAlgorithms
    {
        #region The Classic Way
        public static void BubbleSortAscending(int[] Arr)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (SortingFunctions.SortAscending(Arr[j], Arr[j + 1]))
                        // Instead of Arr[j] > Arr[j + 1]
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        public static void BubbleSortDescending(int[] Arr)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (SortingFunctions.SortDescending(Arr[j], Arr[j + 1]))
                        // Instead of Arr[j] < Arr[j + 1]
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion

        #region The Delegate Way
        public static void BubbleSort01(int[] Arr, ConditionFuncDelegate reference)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion

        #region Delegates + Generics
        public static void BubbleSort02<T>(T[] Arr, ConditionFuncDelegate<T> reference)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion

        private static void SWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        // Generic way
        private static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
