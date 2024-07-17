using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IMovable
    {
        // public is the default access modifier
        void Forward();
        void Backward();
        void Right();
        void Left();
    }
}
