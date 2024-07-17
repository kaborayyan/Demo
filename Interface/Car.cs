using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Car : Vehicle, IMovable
    {
        public void Forward()
        {
            Console.WriteLine("A car can move forward on ground");
        }
        public void Backward()
        {
            throw new NotImplementedException();
        }
        public void Right()
        {
            throw new NotImplementedException();
        }
        public void Left()
        {
            throw new NotImplementedException();
        }
    }
}
