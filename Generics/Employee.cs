using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal /*struct*/ class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }

        public static bool operator == (Employee left, Employee right)
        {
            // return (left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary)
            return left.Equals(right);
        }

        public static bool operator != (Employee left, Employee right)
        {
            // return (left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary)
            return !left.Equals(right);
        }

        public override bool Equals(object? obj)
        {
            Employee? emp = (Employee?)obj; // Explicit unsafe casting
            return (this.Id == emp?.Id) && (this.Name == emp?.Name) && (this.Salary == emp?.Salary);
        }

        // if we override Equals, we need to override GetHashCode also
        public override int GetHashCode()
        {
            // return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? 0 + this.Salary.GetHashCode();
            // Old way because if we have two objects
            // Id: 10, Name: Karim, Salary 1000
            // Id: 1000, Name: Karim, Salary 10
            // They will be equal although different objects
            return HashCode.Combine(Id.GetHashCode(), Name?.GetHashCode(), Salary.GetHashCode());
        }

        // Based on Salary
        //public int CompareTo(object? obj)
        //{
        //    // Employee? PassedEmployee = (Employee?)obj; // Unsafe Explicit Casting
        //    // return this.Salary.CompareTo(PassedEmployee?.Salary);

        //    /*
        //    #region is Conditional Operator
        //    // We use is Conditional Operator
        //    // It returns true or false
        //    // It will return in 2 situations only
        //    // 1. Obj is an Employee
        //    // 2. Obj is a class that inherit from Employee

        //    // No need for null check here
        //    // CompareTo is object member method = there will always be an object
        //    // However the passed object may be null hence why "CompareTo(Object?)" in the beginning
        //    if (this is Employee PassedEmployee)
        //    {
        //        return this.Salary.CompareTo(PassedEmployee.Salary);
        //    }
        //    return 1; // if the passed object is null, the base Employee will be bigger automatically 
        //    #endregion
        //    */

        //    #region As Casting Operator
        //    // We can use As casting Operator
        //    Employee? PassedEmployee = obj as Employee;
        //    // The casting will succeed in two cases
        //    // 1. Obj is an Employee
        //    // 2. Obj is a class that inherit from Employee
        //    // If failed, it will return null
        //    return this.Salary.CompareTo(PassedEmployee?.Salary);
        //    #endregion
        //}

        public int CompareTo(Employee? other)
        {
            return this.Salary.CompareTo(other?.Salary);
        }
    }
}
