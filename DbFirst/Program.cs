using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;
using DbFirst.Contexts;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scaffold-DbContext is used for mapping db first

            //Scaffold - DbContext "Server=MOHAMED_PC;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer - Context AppDbContext - OutputDir Data\Models

            NorthwindContext context = new NorthwindContext();

            var result = context.Categories.ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.CategoryName);
            }

            // Run SQL Query
            // 1. Select Statement : FromSqlRaw(), FromSqlInterpolated()
            
            result = context.Categories.FromSqlRaw("SELECT * FROM Categories").ToList();

            result = context.Categories.FromSqlInterpolated($"SELECT * FROM Categories WHERE CategoryID = {1}").ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item.CategoryName);
            }

            // 2. DML Statement [Update - Insert - Delete] : ExecuteSqlRaw(), ExecuteSqlInterpolated()

            context.Categories.FromSqlRaw("UPDATE Categories SET CategoryName = 'New Name' WHERE CategoryID = 1");

            context.Categories.FromSqlInterpolated($"UPDATE Categories SET CategoryName = 'New Name' WHERE CategoryID = {1}");

            // 3. Stored Procedures : FromSqlRaw(), FromSqlInterpolated()

            result = context.Categories.FromSqlRaw("EXEC dbo.GetCategories").ToList();

            result = context.Categories.FromSqlInterpolated($"EXEC dbo.GetCategories").ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.CategoryName);
            }

            // 4. Functions : FromSqlRaw(), FromSqlInterpolated()

            result = context.Categories.FromSqlRaw("SELECT * FROM dbo.GetCategories()").ToList();

            result = context.Categories.FromSqlInterpolated($"SELECT * FROM dbo.GetCategories()").ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.CategoryName);
            }
        }
    }
}
