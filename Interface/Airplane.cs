using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Airplane : Vehicle, IMovable, IFlyable
    {
        // Forward() was implemented implicitly
        public void Forward()
        {
            Console.WriteLine("An airplane can move forward");
        }

        void IMovable.Backward()
        {
            Console.WriteLine("An airplane can move backward on the ground.");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("An airplane can't fly backward");
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }

        // To implement the remaining methods explicitly
        // Rt click on the Interface name or Ctrl + .

    }
}
