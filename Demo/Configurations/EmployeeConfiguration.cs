using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            //builder.Property(e => e.Department).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Salary).HasColumnType("decimal(18,2)");

            builder.HasOne(e => e.Department).WithMany(e => e.Employees).HasForeignKey(e => e.DepartmentId);

        }

    }
}
