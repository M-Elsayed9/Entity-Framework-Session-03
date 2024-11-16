using Demo.Contexts;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EF Core does not load the navigational properties by default

            using AppDbContext context = new AppDbContext();

            var result = context.Employees.FirstOrDefault(e => e.Id == 2);

            Console.WriteLine(result?.Id ?? 0);
            Console.WriteLine(result?.Name ?? "NA");
            Console.WriteLine(result?.Salary ?? 0);
            Console.WriteLine(result?.Address ?? "NA");
            Console.WriteLine(result?.Department.Name ?? "NA");

            var department = context.Departments.FirstOrDefault(e => e.Id == 1);

            Console.WriteLine(department?.Name ?? "NA");

            foreach (var emp in department.Employees)
            {
                Console.WriteLine(emp.Name);
            }

            //Loading of the navigational properties can be done using 3 ways 
            //1. Eager Loading
            //2. Explicit Loading
            //3. Lazy Loading

        }
    }
}
