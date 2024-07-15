using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    // TypeD => Direct Parent TypeC
    // TypeD => Indirect Parent TypeA, TypeB

    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I'm derived (Child of Grand Child)");
        }

        // new => end old sequence
        // virtual => start new sequence
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD A: {A}, B: {B}, C: {C}, D: {D}");
        }

    }

}
