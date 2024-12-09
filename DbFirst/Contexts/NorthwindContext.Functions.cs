﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using DbFirst.Models;

namespace DbFirst.Contexts
{
    public partial class NorthwindContext
    {

        [DbFunction("DateOnly", "dbo")]
        public static string DateOnly(DateTime? InDateTime)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("LookByFName", "dbo")]
        public IQueryable<LookByFNameResult> LookByFName(string FirstLetter)
        {
            return FromExpression(() => LookByFName(FirstLetter));
        }

        [DbFunction("MyRound", "dbo")]
        public static decimal? MyRound(decimal? Operand, int? Places)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        protected void OnModelCreatingGeneratedFunctions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LookByFNameResult>().HasNoKey();
        }
    }
}
