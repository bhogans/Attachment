using Attachment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Attachment.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Files> Files { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\SQLExpress; Initial Catalog=Attachment1;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configures one-to-many relationship
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Files)
                .WithOne(c => c.Employee);                
                

            //Employee
            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee { EmployeeId = 1, FirstName = "Raziyah", LastName = "Hogans", Age = 44, Email = "razhog@gmail.com", PhoneNumber = "202-333-4444", StartDate = DateTime.Parse("3/15/2022"), CreatedAOn = DateTime.Today },
                    new Employee { EmployeeId = 2, FirstName = "Mike", LastName = "Franklin", Age = 44, Email = "mfrank@gmail.com", PhoneNumber = "202-561-2367", StartDate = DateTime.Parse("3/31/2022"), CreatedAOn = DateTime.Today },
                    new Employee { EmployeeId = 3, FirstName = "John", LastName = "Smith", Age = 44, Email = "jsmith@gmail.com", PhoneNumber = "202-723-4434", StartDate = DateTime.Parse("4/22/2022"), CreatedAOn = DateTime.Today }
                );

        }
    }
}
