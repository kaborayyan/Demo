using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Class : Class => Inheritance
    // Class : Interface => Implementation
    // Class : Abstract Class => Inherit already implemented part, implement non implemented part 
    abstract class RectBase : Shape
    {
        protected RectBase(decimal dim01, decimal dim02):base(dim01, dim02)
        {
        }
        public override decimal CalcArea() // must use override
        {
            return Dim01 * Dim02;
        }
    }
}
