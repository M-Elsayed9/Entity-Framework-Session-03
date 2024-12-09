using Demo.Contexts;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

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

            #region Explicit Loading
            // Explicit Loading

            //var employee  = context.Employees.FirstOrDefault(e => e.Id == 2);
            //context.Entry(employee).Reference("Department").Load(); // loading the Department navigational property

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Department.Name ?? "NA");

            //var department = context.Departments.FirstOrDefault(e => e.Id == 1);

            //context.Entry(department).Collection(e => e.Employees).Load(); // loading the Employees navigational property

            //Console.WriteLine(department?.Name ?? "NA"); // NA is printed if department is null

            //foreach (var emp in department.Employees)
            //{
            //    Console.WriteLine(emp.Name);
            //} 
            #endregion

            #region Eager Loading
            //var employee = context.Employees.Include("Department").FirstOrDefault(e => e.Id == 2);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Department.Name ?? "NA");

            //var department = context.Departments.Include(d => d.Employees).FirstOrDefault(e => e.Id == 1);

            //Console.WriteLine(department?.Name ?? "NA"); // NA is printed if department is null

            //foreach (var emp in department.Employees)
            //{
            //    Console.WriteLine(emp.Name);
            //}
            #endregion

            #region Lazy Loading (Implicitly)
            // 1.  isntalll package Microsoft.EntityFrameworkCore.Proxies
            // 2. Add the following line in the OnConfiguring method of the DbContext class
            // optionsBuilder.UseLazyLoadingProxies();
            // 3. Make All Entities public 
            // 4. Make the navigational properties public virtual

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 2);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Department.Name ?? "NA");

            //var department = context.Departments.FirstOrDefault(e => e.Id == 1);

            //Console.WriteLine(department?.Name ?? "NA"); // NA is printed if department is null

            //foreach (var emp in department.Employees)
            //{
            //    Console.WriteLine(emp.Name);
            //} 
            #endregion

            #region Join Operators

            // inner join 
            // fluent syntax
            //var result = context.Employees.Join(context.Departments,
            //    e => e.DepartmentId,
            //    d => d.Id,
            //    (E, D) => new
            //    {
            //        EmployeeName = E.Name,
            //        EmployeeId = E.Id,
            //        DepartmentId = D.Id,
            //        DepartmentName = D.Name
            //    }
            //    );

            //// query syntax
            //result = from e in context.Employees
            //         join d in context.Departments
            //         on e.DepartmentId equals d.Id
            //         select new
            //         {
            //             EmployeeName = e.Name,
            //             EmployeeId = e.Id,
            //             DepartmentId = d.Id,
            //             DepartmentName = d.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.EmployeeName + " " + item.DepartmentName);
            //}

            #endregion

            #region Tracking vs No Tracking

            // default is Tracking
            var employee = context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == 2);

            //Console.WriteLine(context.Entry(employee).State); // Unchanged = > Tracked

            //employee.Name = "John";

            //Console.WriteLine(context.Entry(employee).State); // Modified = > local changes are tracked

            //context.SaveChanges();
            #endregion

            #region Local VS Remote

            //context.Employees.Load(); 

            //context.Employees.Any(); 

            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();


            #endregion

            #region Mapping View

            var result = context.Courses.FromSqlRaw("SELECT * FROM vwEmployee");

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
            #endregion
        }
    }
}
