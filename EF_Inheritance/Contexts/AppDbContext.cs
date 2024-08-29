using EF_Inheritance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Inheritance.Contexts
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF_Inheritance; Trusted_Connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPC tables creation
            // To create separate tables for the inheritance Classes TPC
            // modelBuilder.Entity<Employee>().ToTable("Employees");
            // modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            // modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            // Since they are Classes with inheritance EF will create the foreign keys automatically
            #endregion

            #region TPH table creation
            // You need to add those lines if you deleted the DbSet of both Classes
            // Since you marked Employee as an abstract Class
            // modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            // modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}
