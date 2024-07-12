namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Types
            // To allow null values add? after the data type
            int X = 10; // does not allow null
            int? Y = null; // allows null
            Y = X; // Valid but the opposite is invalid

            Nullable<int> Z; // This was the old way of doing it, not used anymore
            Z = (int?)X; // Old way since it's considered casting, do not use

            int? A = null;
            int B = (int)A; // Explicit Casting Unsafe

            // How to do it safely?
            int C;

            //if (A != null)
            //{
            //    C = (int)A;
            //}
            //else
            //{
            //    C = 0;
            //}

            C = A != null ? (int)A : 0; // same as above

            //if (A.HasValue)
            //{
            //    C = (int)A;
            //}
            //else
            //{
            //    C = A.Value;
            //}

            C = A.HasValue ? A.Value : 0; // Safe Casting, no warning 
            #endregion

            #region Reference Types
            // Null is the default value for reference types
            string NotNullable = default; // null
            NotNullable = null;
            // Both accepted but with warning because you allocated memory for a null value

            NotNullable = null!; // Null forgiveness operator

            string? Nullable = null; // the correct way to do it

            // Remember Null is not a problem in reference data types
            NotNullable = Nullable; // Possible here but was not possible in Value types 

            Console.WriteLine(Nullable);
            Console.WriteLine(NotNullable);
            #endregion

            #region Null Propagation Operator
            int[] Numbers = null; // Null Reference Exception

            // To Avoid NullReferenceException
            // The first long way
            for (int i = 0; (Numbers != null) && (i < Numbers.Length); i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            // Another long way but more efficient
            // It won't start looping if the if condition is false
            if (Numbers != null)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Console.WriteLine(Numbers[i]);
                }
            }

            // The shorter way but less efficient
            // It will start the loop
            for (int i = 0; i < Numbers?.Length; i++) // add ? to the Array name
            {
                Console.WriteLine(Numbers[i]);
            }

            //Null coalescing operator
            int Length = Numbers?.Length ?? 0;

            // We use Null Propagation operator and Null Coalescing operator when dealing with database
            Employee Employee01 = new Employee();
            Employee01.Name = "Karim";
            Employee01.Department.DeptName = "IT";

            // We use them to avoid null exception
            Console.WriteLine(Employee01?.Department?.DeptName ?? "Department Not Found"); // Safe
            #endregion
        }
    }
}
