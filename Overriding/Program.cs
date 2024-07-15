namespace Overriding
{
    internal class Program
    {
        public static void ProcessEmployee(Employee employee) // Binding
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }

        static void Main(string[] args)
        {
            // Polymorphism has two parts
            // 1. Overloading
            // 2. Overriding

            // Overriding
            // Only in Classes, not supported in Structs
            // Only with inheritance
            // It uses two keywords
            // 1. new
            // 2. override
            // Check Class TypeB Code

            TypeA ObjectA = new TypeA(1);
            ObjectA.A = 10;
            ObjectA.MyFun01();
            ObjectA.MyFun02();

            Console.WriteLine("=====================");

            TypeB ObjectB = new TypeB(1, 2);
            ObjectB.A = 10;
            ObjectB.B = 20;
            ObjectB.MyFun01();
            ObjectB.MyFun02();

            Console.WriteLine("=====================");

            #region Binding
            // Binding
            // Reference from Parent pointing at Object from Child

            TypeA Refbase;
            // Declare for reference from Class TypeA
            // Can refer to an object from Class TypeA
            // OR ANY OTHER Class that inherits from TypeA "example TypeB"
            Refbase = new TypeB(1, 2);
            // This is called Binding
            Refbase.A = 10;
            // Refbase.B = 20; // invalid
            Refbase.MyFun01(); // from TypeA "I'm Base (Parent)"
            Refbase.MyFun02(); // from TypeB due to the keyword override TypeB A: 10, B: 2

            Console.WriteLine("=====================");

            // Not Binding            
            // Reference from Child => Object from Parent
            // TypeB ChildRef = new TypeA(); // Invalid
            // TypeB ChildRef = (TypeB)new TypeA(1); // Valid but not Binding
                                                  // Unsafe Casting
                                                  // Explicit Casting
                                                  // Will cause exception
            Console.WriteLine("=====================");
            
            TypeA ObjA = new TypeC(1, 2, 3);
            // Binding done
            ObjA.A = 10; // Valid
            // ObjA.B = 20; // Invalid
            // ObjA.C = 30; // Invalid

            ObjA.MyFun01(); // Static binding => I'm Parent "from TypeA"
            ObjA.MyFun02(); // Dynamic binding => A = 10, B = 2, C = 3
            Console.WriteLine("=====================");

            TypeB ObjB = new TypeC(1, 2, 3);
            // Binding done
            ObjB.A = 10; // Valid
            ObjB.B = 20; // Valid
            // ObjB.C = 30; // Invalid

            ObjB.MyFun01(); // Static binding => I'm Child "from TypeB"
            ObjB.MyFun02(); // Dynamic binding => A = 10, B = 20, C = 3
            Console.WriteLine("=====================");

            TypeA NewObjA = new TypeE(1, 2, 3, 4, 5); // indirect parent
            TypeB NewObjB = new TypeE(1, 2, 3, 4, 5); // indirect parent
            TypeC NewObjC = new TypeE(1, 2, 3, 4, 5); // indirect parent

            NewObjA.MyFun02();
            NewObjB.MyFun02();
            NewObjC.MyFun02();
            // Last override was TypeC
            // They will return the same result
            
            Console.WriteLine("=====================");
            
            TypeD NewObjD = new TypeE(1, 2, 3, 4, 5); // indirect parent
            NewObjD.MyFun02();
            // Last override TypeE
            #endregion

            #region Employee
            FulltimeEmployee FullTimeEmp = new FulltimeEmployee(10, "Karim", 43, 2500);
            ProcessEmployee(FullTimeEmp); // I'm an Employee "Static Binding"

            ParttimeEmployee PartTimeEmp = new ParttimeEmployee()
            {
                Id = 20,
                Name = "Fayez",
                Age = 45,
                Hours = 20,
                HourRate = 2.5m,
            };
            // This is called: Object Initializer
            
            // You can also enter the data manually
            //PartTimeEmp.Id = 20;
            //PartTimeEmp.Name = "Fayez";
            //PartTimeEmp.Age = 45;
            //PartTimeEmp.Hours = 20;
            //PartTimeEmp.HourRate = 2.5m;

            ProcessEmployee(PartTimeEmp); // I'm an Employee "Static Binding"
            Console.WriteLine("=====================");
            #endregion

        }
    }
}
