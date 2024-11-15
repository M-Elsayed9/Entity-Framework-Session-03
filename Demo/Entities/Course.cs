﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
    }
}
