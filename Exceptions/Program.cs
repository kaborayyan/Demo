namespace Exceptions
{
    internal class Program
    {
        static void DoSomeCode() // wrong way
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine()); // System.FormatException
                Y = int.Parse(Console.ReadLine());
                Z = X / Y; // System.DividedByZeroException

                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100; // System.OutOfRangeException
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void DoSomeProtectedCode() // Correct way
        {
            // Use protected code
            //   Use Boolean variables
            //   Use TryParse instead of Parse
            //   Use Loops to check the entered code
            //   Take care of null values
            //   After doing all this use Try..Catch to catch any unexpected errors
            int X, Y, Z;
            bool Flag;
            do
            {
                Console.WriteLine("Please enter the first number:");
                Flag = int.TryParse(Console.ReadLine(), out X);

            } while (!Flag);

            do
            {
                Console.WriteLine("Please enter the second number:");
                Flag = int.TryParse(Console.ReadLine(), out Y);

            } while (!Flag || Y == 0);

            Z = X / Y;

            int[] Numbers = { 1, 2, 3 };
            if (Numbers?.Length > 10) // to avoid NullReferenceException
            {
                Numbers[10] = 100;
            }

        }
        static void Main(string[] args)
        {
            // VERY IMPORTANT
            // any Variables that are defined in the try block are LOCAL Variables
            // You can not use it else where
            try
            {
                DoSomeProtectedCode();
                // throw new Exception(); this is used for testing, don't write it
            }
            // If anything happens, CLR will create an Object from the Class: Exception
            // We can also use catch (OutOfRangeException ex) or catch (DividedByZeroException ex)
            // But using (Exception ex) is recommended
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // You should either save the exception in log file or in the database
                // to debug and fix it later
            }
            finally
            {
                // deallocated = delete = close unmanaged resources
                // handle connection with database
                Console.WriteLine("Finally");

            }
            Console.WriteLine("After try catch");
        }
    }
}