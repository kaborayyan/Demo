using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    // Extension Classes and Methods should be static
    internal static class intExtensions
    {
        public static int Reverse(this int Number) // this means the passed object is the same caller
        {
            int ReversedNumber = 0, LastDigit;
            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNumber = (ReversedNumber * 10) + LastDigit;

                Number /= 10;
            }
            return ReversedNumber;
        }

        public static long Reverse(this long Number)
        {
            long ReversedNumber = 0, LastDigit;
            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNumber = (ReversedNumber * 10) + LastDigit;

                Number /= 10;
            }
            return ReversedNumber;
        }

        public static double Reverse(this double Number)
        {
            double ReversedNumber = 0, LastDigit;
            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNumber = (ReversedNumber * 10) + LastDigit;

                Number /= 10;
            }
            return ReversedNumber;
        }
    }
}
