﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class TypeE : TypeD
    {
        public int E { get; set; }

        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            E = e;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I'm derived (Grand Child of Grand Child)");
        }

        public override void MyFun02() // Override new sequence
        {
            Console.WriteLine($"TypeE A: {A}, B: {B}, C: {C}, D: {D}, E: {E}");
        }

    }
}
