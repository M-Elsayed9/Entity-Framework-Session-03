﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Models;

[Keyless]
public partial class Quarterly_Order
{
    [StringLength(5)]
    public string? CustomerID { get; set; }

    [StringLength(40)]
    public string? CompanyName { get; set; }

    [StringLength(15)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? Country { get; set; }
}