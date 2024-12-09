using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scaffold-DbContext is used for mapping db first

            //Scaffold - DbContext "Server=MOHAMED_PC;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer - Context AppDbContext - OutputDir Data\Models

            using AppDbContext context = new AppDbContext(); 

            var result = context.Categories.ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.CategoryName);
            }

        }
    }
}
