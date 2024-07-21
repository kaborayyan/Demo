using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Circle : Shape
    {
        public Circle(decimal radius) : base(radius, radius)
        {
            // Dim01 = Dim02 = radius; // not needed
        }
        public override decimal Perimeter => 2 * 3.14M * Dim01;

        public override decimal CalcArea() => 3.14M * Dim01 * Dim02;

    }
}
