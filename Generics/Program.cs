namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics
            int A = 10, B = 20;
            Console.WriteLine($"A = {A}, B = {B}");
            Helper<int>.SWAP(ref A, ref B);
            Console.WriteLine("After SWAP");
            Console.WriteLine($"A = {A}, B = {B}");

            Point P01 = new Point(1, 2);
            Point P02 = new Point(10, 20);
            Console.WriteLine(P01);
            Console.WriteLine(P02);
            Helper<Point>.SWAP(ref P01, ref P02);
            Console.WriteLine("After SWAP");
            Console.WriteLine(P01);
            Console.WriteLine(P02);

            int[] Numbers = { 4, 5, 6, 9, 3, 2, 8, 1, 7 };
            int index = Helper<int>.SearchArray(Numbers, 6);
            Console.WriteLine($"The value is present in location {index}");

            Employee Emp01 = new Employee() { Id = 10, Name = "Aliaa", Salary = 3000 };
            Employee Emp02 = new Employee() { Id = 20, Name = "Tarek", Salary = 2500 };
            Employee Emp03 = new Employee() { Id = 10, Name = "Aliaa", Salary = 3000 };

            if (Emp01 == Emp02) // reference comparison
            {
                Console.WriteLine("They're equal");
            }
            else
            {
                Console.WriteLine("They're not equal");
            }

            // Equals in struct will compare the data itself because structs are value types
            // Equals in class will compare the address in stack not the object in the heap
            // in class you will have to override Equals or ==
            // Overriding Equals is better since == is not present in all data types

            if (Emp01.Equals(Emp02)) // object comparison
            {
                Console.WriteLine("They're equal");
            }
            else
            {
                Console.WriteLine("They're not equal");
            }

            Employee[] employees = new Employee[2] // no need to write this part
            {
                Emp01,
                Emp02,
            };

            int empIndex = Helper<Employee>.SearchArray(employees, Emp03);
            Console.WriteLine(empIndex);

            #endregion

            #region Bubble Sort

            foreach (int number in Numbers)
            {
                Console.Write($"{number} ");
            }
            Utility<int>.BubbleSort(Numbers);
            Console.WriteLine("\nAfter bubble sort");
            foreach (int number in Numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Employee[] NewEmployees = new Employee[5]
            {
                new Employee() { Id = 05, Name = "Karim", Salary = 2500 },
                new Employee() { Id = 10, Name = "Fayez", Salary = 2000 },
                new Employee() { Id = 15, Name = "Kobesy", Salary = 3000 },
                new Employee() { Id = 20, Name = "Rayyan", Salary = 1500 },
                new Employee() { Id = 25, Name = "Fekry", Salary = 2000 }
            };

            Utility<Employee>.BubbleSort(NewEmployees);
            foreach (Employee emp in NewEmployees)
            {
                Console.WriteLine(emp);
            }

            Point[] NewPoints = new Point[5]
            {
                new Point(5, 7),
                new Point(2, 11),
                new Point(5, 23),
                new Point(9, 4),
                new Point(3, 8),
            };

            Utility<Point>.BubbleSort(NewPoints);
            foreach (Point point in NewPoints)
            {
                Console.WriteLine(point);
            }
            #endregion

            #region Other Constraints
            // Primary Constraints [0:1]
            // Secondary Interface Constraints [0:M]
            // Constructor Constraints [0:-1]

            // Primary means choose one only of those
            // You must choose datatype of those: class - struct - enums
            // or they are notNull
            // We can use a user defined class "must be not sealed"

            // Secondary Interface Constraints [0:M]
            // Many Interfaces or none

            // Constructor Constraints [0:-1]
            #endregion
        }
    }
}
