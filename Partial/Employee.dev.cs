using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    // Same name but Name.dev.cs
    internal partial class Employee
    {
        public void Print()
        {
            Console.WriteLine("I'm an Employee");
        }
        public partial void Message()
        {
            Console.WriteLine("This is a message");
        }
        public int Test { get; set; }
    }
}
