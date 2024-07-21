using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Rectangle = Concrete Class: Fully Implemented Class
    class Rectangle : RectBase
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal Perimeter
        {
            get
            {
                return (Dim01 + Dim02) * 2;
            }
        }        
    }
}
