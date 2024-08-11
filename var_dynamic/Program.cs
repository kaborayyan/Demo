namespace var_dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Keywords: implicit typed local variable "var - dynamic"

            // var
            // Since C# is a strong typed language
            // You must assign a data type to each variable you declare
            // var will assign the data type based on the data passed to the variable
            // that's why you need to assign initial value once you use var
            // Once assigned, you can't the change the data type later
            // Yoy can't use it as a return type in a Method

            var Data01 = "Ahmed"; // the compiler will assign string to Data01
            var X = 12; // the compiler will assign int to X

            // var X; // Invalid
            // var X = null; // invalid because null is a default value for several types not a data type
            // public var Print(var X) {return X;} // invalid

            // dynamic
            // Also used to implicitly assign data type to a variable
            // Resembles var in JS
            // CLR will detect Datatype based on last value
            // can accept null as an initial value
            // The compiler deals with dynamic as an object
            // Can be used in Methods as a return type
            // Be careful when using it

            dynamic Data02 = "Karim";
            Data02 = 12; // valid
            Data02 = 1.9; // valid
            Data02 = 'a'; // valid

            Console.WriteLine(Data02.GetType().Name);

            // the next code is valid
            static dynamic Print(dynamic X)
            {
                return X;
            }            

        }
    }
}
