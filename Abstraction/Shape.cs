using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Abstract Class: Partially Implemented Class
    // Can not create Object
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        
        // Abstract Properties does not generate backing field
        public abstract decimal Perimeter { get; }
        public Shape(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        public abstract decimal CalcArea();
        // Not implemented method = abstract method
        // Must be in abstract Class
    }
}
