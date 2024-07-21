using System;
using System.Xml.Linq;

namespace Overloading
{
    internal class Program
    {
        // Polymorphism
        // 1. Overloading (Same Constructors Name but different Parameters)
        // 2. Overriding (in Classes only since it needs Inheritance)

        #region Overloading
        // 1. Constructor overloading
        // 2. Indexer overloading
        // 3. Method overloading
        // 4. Operator overloading
        // 5. Casting Operator overloading


        #region Method Overloading
        // Method - Constructor Overloading
        // Supported in both Classes and Structs
        // Parameters must differ in order, count, type or all
        // Which copy is used is determined when you pass the arguments
        // Method overloading is for readability only
        public static int Sum(int X, int Y)
        {
            return X + Y;
        }

        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }

        public static double Sum(double X, double Y)
        {
            return X + Y;
        }

        public static double Sum(int X, double Y)
        {
            return X + Y;
        }
        #endregion

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));

            // Example: Console.WriteLine has 18 overloads

            #region Operator Overloading
            // Operator Overloading
            // 1. Binary +, -, *, /, %
            // 2. Unary ++, --
            // 3. Relational <, >

            // Binary Operators
            Complex C01 = new Complex() { Real = 2, Imaginary = 4 };
            Console.WriteLine(C01);

            Complex C02 = new Complex() { Real = 3, Imaginary = 5 };
            Console.WriteLine(C02);

            Complex C03 = default;

            C03 = C01 + C02; // before operator overloading, it will be invalid
            Console.WriteLine(C03);
            Console.WriteLine("====================");
            C03 = C01 - C02; // before operator overloading, it will be invalid
            Console.WriteLine(C03);
            Console.WriteLine("====================");
            C03 += C01; // C03 -= C01; // will also work
            Console.WriteLine(C03);
            Console.WriteLine("====================");

            // Unary Operators
            C03 = ++C01;
            C03 = C01++;
            Console.WriteLine(C03);
            Console.WriteLine("====================");
            C03 = --C01;
            Console.WriteLine(C03);
            Console.WriteLine("====================");

            // Relational Operators
            if (C01 > C02)
            {
                Console.WriteLine("C01 is bigger");
            }
            else
            {
                Console.WriteLine("C02 is bigger");
            }

            // Casting Operator Overloading

            Complex C04 = new Complex() { Real = 2, Imaginary = 4 };
            int Y = (int)C04; // Valid after overloading
            Console.WriteLine(C04);
            Console.WriteLine(Y);

            string S04 = (string)C04;
            // string S04 = C04;
            // Both are correct
            // The Explicit Casting is the preferred
            // Due to readability

            #endregion

            #region Mapping
            // DataBase => Employee[Model] => EmployeeViewModel => View
            // View => EmployeeViewModel => Employee[Model] => DataBase

            Employee Emp01 = new Employee()
            {
                Id = 10,
                FullName = "Aliaa Tarek",
                Password = "password",
                Email = "AliaaTarek42@gmail.com",
                SecurityStamp = Guid.NewGuid()
            };
            // Employee[Model] => EmployeeViewModel
            EmployeeViewModel employeeView = (EmployeeViewModel)Emp01; // Casting

            Console.WriteLine($"Full Name from User: {Emp01.FullName}");
            Console.WriteLine($"First name from UserViewModel: {employeeView.FirstName}");
            Console.WriteLine($"Full name from UserViewModel: {employeeView.LastName}");
            #endregion
        }
    }
}
