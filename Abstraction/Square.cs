using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Square : RectBase
    {
        public Square(decimal dim): base(dim,dim)
        {
            // Dim01 = Dim02 = dim; // not needed
        }
        
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }        
    }
}
