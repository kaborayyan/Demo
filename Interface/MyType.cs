using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // This is Developer 02
    internal class MyType : IMyType
    {
        // Rt Click on the interface name to implement
        // The extra text is important if you forgot to implement any part of the interface
        
        // public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // You can add more properties and more methods but you can't make them less
        public int Id { get; set; }

        // You must follow the signature of the Method
        public void MyFun(int X)
           // throw new NotImplementedException();
           // If single line use =>
           => Console.WriteLine($"Hello Karim Id = {Id} and X = {X}");
    }
}
