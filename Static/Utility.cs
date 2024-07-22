using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal static class Utility // Can not create object from static Class
    {       
        // Class Member Constructor
        // Static Constructor
        // Can't specify access modifiers or Parameters
        // Will be executed once only per Class Life cycle
        // 1. Call Static Method or Property
        // 2. Create Object from this Class or another Class inheriting from this one
        static Utility()
        {
            // Used to initialize Static attributes
            pi = 3.14;
        }

        // CM to Inch
        // Object Member Method "Non static". Needs an object to function 
        // Class Member Method "static"
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        // Important
        // You can't use any property inside a static Class
        // Properties are linked to objects
        // Static methods are not linked to objects

        // You need a static property = Class member property
        // Must {get; set;}
        // A static Attribute
        // A Constant

        private readonly static double pi; // readonly means no set
        public static double Pi
        {
            get { return pi; }
            // set { pi = value; } // Should not be able to change its value
        }

        // Or you can use a constant
        public const double Pie = 3.14; // Must assign value at once
        // You can't change a const inside a Constructor

        // Calculate Circle Area
        public static double CalcCircleArea(double radius)
        {
            return Pie * radius * radius;
        }
    }
}
