using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example.Models
{
    internal class PartTimeEmployee : Employee
    {
        public  int NumberOfHours { get; set; }
        public decimal HourRate { get; set; }
    }
}
