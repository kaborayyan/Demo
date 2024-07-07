using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA TestObject = new TypeA();
            // TypeA is public, you can access it anywhere inside its project
            // TestObject.X = 10; Not valid because X is private
            TestObject.Y = 20; // allowed inside the same project "TestClassLibrary"
        }
    }
}
