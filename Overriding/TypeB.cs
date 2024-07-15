using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a) // Constructor chaining
        {
            B = b;
        }

        public new void MyFun01() // new => new version of MyFun01()
        {
            // Because Function01 is "Static Binding" is done using the keyword "new"
            // This happens in compilation time "Early Binding"
            // The Compiler will bind the function based on reference not the object
            Console.WriteLine("I'm derived (Child)");
        }

        public override void MyFun02()
        {
            // Function02 is "Dynamic Binding" using the keyword override
            // The function must be "public virtual" to do this
            // It happens in run time
            // When CLR finds the word virtual, it will search for the last override
            // The CLR will bind the function based on the object not the reference
            // Check the binding part to understand more

            Console.WriteLine($"TypeB A: {A}, B: {B}");
        }

    }
}
