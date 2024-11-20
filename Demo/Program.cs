using Demo.Contexts;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EF Core does not load the navigational properties by default

            using AppDbContext context = new AppDbContext();

            ////Loading of the navigational properties can be done using 3 ways 
            //1. Explicit Loading
            //2. Eager Loading
            //3. Lazy Loading

            // Explicit Loading

            //var employee  = context.Employees.FirstOrDefault(e => e.Id == 2);
            //context.Entry(employee).Reference("Department").Load(); // loading the Department navigational property

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Department.Name ?? "NA");

            var department = context.Departments.FirstOrDefault(e => e.Id == 1);

            context.Entry(department).Collection(e => e.Employees).Load(); // loading the Employees navigational property

            Console.WriteLine(department?.Name ?? "NA"); // NA is printed if department is null

            foreach (var emp in department.Employees)
            {
                Console.WriteLine(emp.Name);
            }

        }
    }
}
