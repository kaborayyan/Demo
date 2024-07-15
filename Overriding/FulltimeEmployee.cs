using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class FulltimeEmployee : Employee
    {

        public decimal Salary { get; set; }
        
        public FulltimeEmployee(int id, string name, int age, decimal salary) : base(id, name, age)
        {
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm a Full-time Employee.");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Fulltime Employee: Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary}");
        }

    }
}
