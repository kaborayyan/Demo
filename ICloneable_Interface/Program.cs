using System.Text;

namespace ICloneable_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ICloneable
            Employee Emp01 = new Employee() { Id = 10, FirstName = "Karim", LastName = new StringBuilder("Mohamed"), Salary = 2500 };
            Employee Emp02 = new Employee() { Id = 20, FirstName = "Moahmed", LastName = new StringBuilder("Fayez"), Salary = 3000 };

            Console.WriteLine($"HC of Emp01: {Emp01.GetHashCode()}"); // 54267293
            Console.WriteLine($"Emp01: {Emp01}");
            Console.WriteLine($"HC of Emp02: {Emp02.GetHashCode()}"); // 18643596
            Console.WriteLine($"Emp02: {Emp02}");
            Console.WriteLine("====================");
            // Shallow Copy
            Emp02 = Emp01;
            Console.WriteLine("After the Shallow Copy");
            Console.WriteLine($"HC of Emp01: {Emp01.GetHashCode()}"); // 54267293
            Console.WriteLine($"Emp01: {Emp01}");
            Console.WriteLine($"HC of Emp02: {Emp02.GetHashCode()}"); // 18643596
            Console.WriteLine($"Emp02: {Emp02}");
            Console.WriteLine("====================");

            Emp01.Id = 30;
            Emp01.FirstName = "Ashraf";
            Emp01.LastName = new StringBuilder("Omar");
            Emp01.Salary = 5000;
            Console.WriteLine("After changing the data");
            Console.WriteLine($"Emp01: {Emp01}"); // 30 Fayez 5000          
            Console.WriteLine($"Emp02: {Emp02}"); // 30 Fayez 5000
            Console.WriteLine("====================");

            // The same will happen if we used StringBuilder
            // In Shallow Copy Both References => Same Object

            Emp02 = (Employee)Emp01.Clone();
            // Create new Object
            Console.WriteLine("After the Deep Copy");
            Emp02.Id = 40;
            Emp02.FirstName = "Mahmoud";
            Emp02.LastName.Append(" Jaber");
            // Emp02.LastName = new StringBuilder("Jaber"); => Different result
            Emp02.Salary = 4000;
            Console.WriteLine($"Emp01: {Emp01}"); // Mahmoud Omar Jaber          
            Console.WriteLine($"Emp02: {Emp02}"); // Ashraf Omar Jaber
            Console.WriteLine("====================");


            // Two ways for Copying user defined data Types
            // 1. Clone()
            // 2. Copy Constructor

            Emp02 = new Employee(Emp01);
            Console.WriteLine("After the Deep Copy by Copy Constructor");
            Emp02.Id = 50;
            Emp02.FirstName = "Maysa";
            Emp02.LastName.Append(" Ali");
            Emp02.Salary = 6000;
            Console.WriteLine($"Emp01: {Emp01}"); //         
            Console.WriteLine($"Emp02: {Emp02}"); // 
            Console.WriteLine("====================");
            #endregion


        }
    }
}
