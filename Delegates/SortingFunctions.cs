using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class SortingFunctions
    {
        // You can't do generics here
        // Different body
        // value vs length

        public static bool SortAscending(int L, int R) { return L > R; }
        public static bool SortDescending(int L, int R) { return L < R; }

        public static bool SortAscending(string L, string R) { return L.Length > R.Length; }
        public static bool SortDescending(string L, string R) { return L.Length < R.Length; }
    }
}

