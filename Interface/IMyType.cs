﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Any Interface should start with the letter "I"
    // Access Modifiers are: internal "Default" and public only

    // This Developer 01
    internal interface IMyType
    {
        // What can you write inside an Interface
        // 1. Signature for property
        // 2. Signature for method
        // 3. Default implement method

        // The Default access modifier is public
        // private is not allowed here

        // 1. Signature for property "Type Name get/set"
        public int Id { get; set; }
        // Here it's called signature for Property
        // But in Class or Struct it's called Automatic Property
        // No hidden field will be generated by the compiler

        // 2. Signature for method "Type Name Parameters"
        public void MyFun(int X);
        // As you can see there's no body

        // 3. Default implemented method
        // It's a normal complete method "Full Prototype"
        public void Print()
        {
            Console.WriteLine("Hello default implemented method from interface");
        }

    }
}
