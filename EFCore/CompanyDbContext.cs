using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    #region DbContext
    // Each database needs its own DbContext
    // Create a Class with the name of the database
    #endregion
    internal class CompanyDbContext: DbContext
    {
        // To be able to use Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region First way to use modelBuilder
            /*
            modelBuilder.Entity<Trainee>().HasKey(T => T.TraineeId);
            // to create PK
            
            modelBuilder.Entity<Trainee>().Property(T => T.TraineeId).UseIdentityColumn(1, 1);
            // to create identity 
            
            // Another ways to do it
            // modelBuilder.Entity<Trainee>().Property("TraineeId").UseIdentityColumn(1, 1); // bad way
            // modelBuilder.Entity<Trainee>().Property(nameof(Trainee.TraineeId)).UseIdentityColumn(1, 1);
            // The least favorite method is the string

            modelBuilder.Entity<Trainee>()
                        .Property(T => T.Name)
                        .HasColumnType("varchar") // take care of syntax
                        .HasMaxLength(50);

            modelBuilder.Entity<Trainee>()
                        .Property(T => T.Salary)
                        .HasColumnType("money"); // take care of syntax

            modelBuilder.Entity<Trainee>()
                        .Property(T => T.Address)
                        .HasMaxLength(50)
                        .HasDefaultValue("Cairo"); 
            */
            #endregion

            #region Second way to use modelBuilder 
            modelBuilder.Entity<Trainee>(T =>
            {
                T.HasKey(T => T.TraineeId);
                T.Property(T => T.TraineeId).UseIdentityColumn(1, 1);
                T.Property(T => T.Name).HasColumnType("varchar").HasMaxLength(50);
                T.Property(T => T.Salary).HasColumnType("money");
                T.Property(T => T.Address).HasMaxLength(50).HasDefaultValue("Cairo");

            });
            #endregion
            modelBuilder.ApplyConfiguration<Student>(new StudentConfigurations());
            // To activate Class StudentConfigurations
            // If you have many use
            // modelBuilder.ApplyConfigurationsFromAssembly

            base.OnModelCreating(modelBuilder);
        }
        // We need to override OnConfiguring
        // Which is responsible for connecting to the server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDB; Trusted_Connection = True; TrustServerCertificate = True");
        }

        // Now we are connected to the server and entered the database
        // We need to tell the machine to create the table
        // For that we need to create a property of type DbSet
        // Which will create a query to create the table
        // For each Class you need to create a table, you need to add a DbSet property
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
