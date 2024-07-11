using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class TypeC : TypeA
    {
        public TypeC()
        {        
            A = 10; // Valid => Private for TypeC
            B = 20; // Valid => Private for TypeC
            C = 30; // Valid => internal

        }
    }
}
