using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StudentCourse> builder)
        {

            builder.HasKey(e => new { e.StudentId, e.CourseId });
            builder.HasOne(e => e.Student).WithMany(e => e.StudentCourses).HasForeignKey(e => e.StudentId);
            builder.HasOne(e => e.Course).WithMany(e => e.CourseStudents).HasForeignKey(e => e.CourseId);
        }
    }
}
