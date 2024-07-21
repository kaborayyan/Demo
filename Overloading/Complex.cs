using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        #region Operators Overloading
        // They must be non private
        // They must be Class member "static" = can be used without creating an object

        #region Binary Operator Overloading
        // You can overload + or - 
        // No need to do both unless you need them both
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real) ?? 0 + (Right?.Real) ?? 0,
                Imaginary = (Left?.Imaginary) ?? 0 + (Right?.Imaginary) ?? 0
                // Left? or Right? => checking if null
                // the we use the null coalescing operators to assign 0 as a value instead of null
            };
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real) ?? 0 + (Right?.Real) ?? 0,
                Imaginary = (Left?.Imaginary) ?? 0 + (Right?.Imaginary) ?? 0
                // Same explanation as above
            };
        }
        #endregion

        #region Unary Operator Overloading
        // You can overload ++ or --
        // No need to overload them both unless you need them both
        public static Complex operator ++ (Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imaginary = C?.Imaginary ?? 0
                // C? check if object is null ?? if it's null return 0
            };
        }

        public static Complex operator -- (Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imaginary = C?.Imaginary ?? 0
                // Read the operators again
            };
        }
        #endregion

        #region Relational Operator Overloading
        // You have to do both operators
        // Both > and < must be overloaded together
        public static bool operator > (Complex Left, Complex Right)
        {
            // Check the explanation
            if (Left.Real == Right.Real)
            {
                return Left.Imaginary > Right.Imaginary;
            }
            else
            {
                return Left.Real > Right.Real;
            }
        }

        public static bool operator <(Complex Left, Complex Right)
        {
            // Check the explanation
            if (Left.Real == Right.Real)
            {
                return Left.Imaginary < Right.Imaginary;
            }
            else
            {
                return Left.Real < Right.Real;
            }
        }
        #endregion

        #region Casting Operator Overloading
        // The old format was
        // public static int explicit operator int
        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }

        // The old format was
        // public static string explicit operator string
        public static /*string*/ implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty; // Empty string ""
        } 
        #endregion
        #endregion

    }

}
