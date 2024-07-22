﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    internal class Parent
    {
        private int salary;
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }
        public virtual void Print()
        {
            Console.WriteLine("I'm Parent.");
        }
    }
}
