using Microsoft.EntityFrameworkCore;
using Project.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Models
{
     

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Status> Statuse { get; set; }
        //public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 1, DepartmentName = "IT" });
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 2, DepartmentName = "HR" });
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //Seed Status Table
            modelBuilder.Entity<Status>().HasData(
                new Status { Sid = 1, InvoiceStatus = "Active" });
            modelBuilder.Entity<Status>().HasData(
                new Status { Sid = 2, InvoiceStatus = "Inactive" });
            modelBuilder.Entity<Status>().HasData(
                new Status { Sid = 3, InvoiceStatus = "Hold" });
            modelBuilder.Entity<Status>().HasData(
                new Status { Sid = 4, InvoiceStatus = "InProgress" });
            modelBuilder.Entity<Status>().HasData(
                new Status { Sid = 5, InvoiceStatus = "Complete" });


            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                Name = "John",
                Email = "john@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Sid=1,
                PhoneNumber ="6909 - 555 - 0175",
                

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                Name = "Sam",
                Email = "Sam@pragimtech.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Sid = 2,

                PhoneNumber = "6909 - 555 - 0175",
                
           
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                Name = "Mary",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Sid = 3,


                PhoneNumber = "6909 - 555 - 0175",
                
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                Name = "Sara",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Sid=4,
            
                PhoneNumber = "6909 - 555 - 0175",
              
              
            });
        }
    }
}
