using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        // Automatic Property
        // Compiler will generate a private field, backing field

        public TypeA(int a)
        {
            A = a;
        }

        // Object member function "Non static"
        public void MyFun01()
        {
            Console.WriteLine("I'm Base (Parent).");
        }

        public virtual void MyFun02() // you need virtual to override in the Child Class
        {
            Console.WriteLine($"TypeA A: {A}.");
        }
    }
}
