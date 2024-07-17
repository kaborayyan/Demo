using Interface;

namespace Interface
{
    // Interfaces are Reference - Non Primitive - User Defined - Data Type
    // Just Like Classes
    // They are a Contract between two developers
    // One wrote it and the other will implement it

    // They solved two problems
    // 1. There was no multi-inheritance between Classes
    // You can implement multiple Interfaces

    // 2. There is no inheritance with Structs
    // Structs can implement multiple Interfaces

    // You can add more functions inside the Class but not less functions
    // At least all the implemented classes should be there

    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
            // It will accept an object from any Class that implement ISeries
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.Current} "); // 0
                    series.GetNext();
                }
                series.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface
            // You can not create an object from the interface
            // But you can create a reference that refer to an Object
            // From a Class or a Struct that implement the Interface
            IMyType myType01; // Correct
                              // CLR will allocate 4 bytes for the reference which refer to null
            myType01 = new MyType(); // new object from the Class MyType
                                     // The next lines are valid now
            myType01.Id = 10;
            myType01.MyFun(60);
            myType01.Print();

            // Remember if I created the object directly from the Class, I won't be able to use the default implemented method

            MyType myType02 = new MyType();
            myType02.Id = 20;
            myType02.MyFun(50);
            // myType02.Print(); // Invalid
            Console.WriteLine("====================");
            #endregion

            #region Interface Example 02
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            Print10NumbersFromSeries(seriesByTwo);
            Console.WriteLine("\n====================");
            #endregion

            #region Interface Example 03
            Car NewCar = new Car();
            NewCar.Forward();

            Airplane NewAirplane = new Airplane();
            NewAirplane.Forward(); // valid
            // NewAirplane.Backward(); // invalid

            // You have to create a reference from the Interface that refer
            // To an Object from the Class Airplane
            IFlyable NewAirplane02 = new Airplane();
            NewAirplane02.Backward(); // Valid

            IMovable NewAirplane03= new Airplane();
            NewAirplane03.Backward();
            #endregion

        }
    }
}

