using Inheritance_Example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example.Contexts
{
    internal class AppDbContext : DbContext
    {
        
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPC
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");

            // TPH
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            //modelBuilder.Entity<Employee>().HasDiscriminator<string>("EmployeeType")
            //    .HasValue<PartTimeEmployee>("PartTime")
            //    .HasValue<FullTimeEmployee>("FullTime");

            // TPCC
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DemoDb3;Trusted_Connection=True;TrustServerCertificate=True;");
        }


    }
}
