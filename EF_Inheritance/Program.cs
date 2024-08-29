using EF_Inheritance.Contexts;
using EF_Inheritance.Models;

namespace EF_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generating Schema
            
            // TPC table per class
            // TPH table per hierarchy
            // TPCC table per concrete class

            // In TPC although you will create DbSet for each Class
            // EF Core will create a single table for them by convention => TPH
            // You will have to do it manually by overriding OnModelCreating

            // Opening the connection to the database
            using AppDbContext context = new AppDbContext();

            #region TPC
            // Separate Objects for separate tables of TPC
            /*
            FullTimeEmployee fullTime = new FullTimeEmployee()
            {
                Name = "Karim",
                Address = "Alexandria",
                Email = "karim@yahoo.com",
                Salary = 12000
            };

            PartTimeEmployee partTime = new PartTimeEmployee()
            {
                Name = "Ahmed",
                Address = "Cairo",
                Email = "ahmed@yahoo.com",
                NumberOfHours = 110,
                HourRate = 100
            };

            context.FullTimeEmployees.Add(fullTime);
            context.PartTimeEmployees.Add(partTime);
            
            context.SaveChanges();
            */
            #endregion

            #region TPH
            // If you deleted the DbSet of both FullTimeEmployee and PatTimeEmployee
            // The only DbSet remaining will be of Employees
            // context.Employees.Add(fullTime);

            // To access the data
            //var Result = context.Employees.OfType<FullTimeEmployee>();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region TPCC
            // For the TPCC
            // We will create two tables only for FullTimeEmployee and PartTimeEmployee
            // To do this you need to delete the DbSet of Employee
            #endregion

        }
    }
}
