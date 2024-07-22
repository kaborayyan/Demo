using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    class Child : Parent
    {
        public sealed override int Salary // { get => base.Salary; set => base.Salary = value; }
        {
            get {return base.Salary;}
            set {base.Salary = value < 5000 ? 5000 : value;}
        }
        // Sealed: can be inherited but can't be overridden
        // Sealed will create dynamic binding
        // new will create static binding
        public sealed override void Print()
        {
            Console.WriteLine("I'm a child.");
        }

    }
}
