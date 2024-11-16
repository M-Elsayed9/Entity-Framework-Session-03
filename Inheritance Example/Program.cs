using Inheritance_Example.Contexts;
using Inheritance_Example.Models;

namespace Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TPC
            // TPH
            // TPCC

            using AppDbContext context = new AppDbContext();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            {
                Name = "John Doe2",
                Email = "sdsd",
                Address = "sdsd",
                Salary = 10000

            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
            {
                Name = "Jane Doe2",
                Email = "sdsd",
                Address = "sdsd",
                HourRate = 100,
                NumberOfHours = 20
            };

            context.FullTimeEmployees.Add(fullTimeEmployee);
            context.PartTimeEmployees.Add(partTimeEmployee);

            var result = context.Employees.OfType<FullTimeEmployee>();

            foreach (var resultItem in result)
            {
                Console.WriteLine(resultItem);
            }

            context.SaveChanges();
        }
    }
}
