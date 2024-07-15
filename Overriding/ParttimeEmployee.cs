using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class ParttimeEmployee : Employee
    {

        public int Hours { get; set; }
        public decimal HourRate { get; set; }
        
        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm a Part-time Employee.");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Parttime Employee: Id = {Id}, Name = {Name}, Age = {Age}, Hours = {Hours}, Hourly Rate = {HourRate}");
        }

    }
}
