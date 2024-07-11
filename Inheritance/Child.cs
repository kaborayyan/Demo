using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Parent // No multiinheritance in C# 
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y) // inherit base constructor
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        public new int Product() // new means new version of the Parent method
        {
            return base.Product() * Z; // X*Y*Z
        }
    }
}
