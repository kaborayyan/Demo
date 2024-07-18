namespace ICompareable_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4]
            {
                new Employee() {Id = 10, Name = "Karim", Salary = 2000 },
                new Employee() {Id = 50, Name = "Fayez", Salary = 3000 },
                new Employee() {Id = 30, Name = "Mahmoud", Salary = 5000 },
                new Employee() {Id = 20, Name = "Ibrahim", Salary = 4000 }
            };

            Array.Sort(employees, new EmployeeIdComparer());
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
