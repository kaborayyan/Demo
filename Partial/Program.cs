namespace Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partial
            // Class, Struct, Interface, Method
            // Two Classes with the same Name, they complete each other
            
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Karim";
            employee.Age = 40;
            employee.Salary = 3000;
            employee.Test = 10; // from the 2nd part of the Class
            employee.Print(); // from the 2nd part of the Class
        }
    }
}
