﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using DbFirst.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DbFirst.Contexts
{
    public partial class NorthwindContext
    {
        private INorthwindContextProcedures _procedures;

        public virtual INorthwindContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new NorthwindContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public INorthwindContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class NorthwindContextProcedures : INorthwindContextProcedures
    {
        private readonly NorthwindContext _context;

        public NorthwindContextProcedures(NorthwindContext context)
        {
            _context = context;
        }

        public virtual async Task<List<CustOrderHistResult>> CustOrderHistAsync(string CustomerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "CustomerID",
                    Size = 10,
                    Value = CustomerID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<CustOrderHistResult>("EXEC @returnValue = [dbo].[CustOrderHist] @CustomerID = @CustomerID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<CustOrdersDetailResult>> CustOrdersDetailAsync(int? OrderID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "OrderID",
                    Value = OrderID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<CustOrdersDetailResult>("EXEC @returnValue = [dbo].[CustOrdersDetail] @OrderID = @OrderID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<CustOrdersOrdersResult>> CustOrdersOrdersAsync(string CustomerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "CustomerID",
                    Size = 10,
                    Value = CustomerID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<CustOrdersOrdersResult>("EXEC @returnValue = [dbo].[CustOrdersOrders] @CustomerID = @CustomerID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<EmployeeSalesbyCountryResult>> EmployeeSalesbyCountryAsync(DateTime? Beginning_Date, DateTime? Ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Beginning_Date",
                    Value = Beginning_Date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "Ending_Date",
                    Value = Ending_Date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<EmployeeSalesbyCountryResult>("EXEC @returnValue = [dbo].[Employee Sales by Country] @Beginning_Date = @Beginning_Date, @Ending_Date = @Ending_Date", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<SalesbyYearResult>> SalesbyYearAsync(DateTime? Beginning_Date, DateTime? Ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Beginning_Date",
                    Value = Beginning_Date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "Ending_Date",
                    Value = Ending_Date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<SalesbyYearResult>("EXEC @returnValue = [dbo].[Sales by Year] @Beginning_Date = @Beginning_Date, @Ending_Date = @Ending_Date", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<SalesByCategoryResult>> SalesByCategoryAsync(string CategoryName, string OrdYear, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "CategoryName",
                    Size = 30,
                    Value = CategoryName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "OrdYear",
                    Size = 8,
                    Value = OrdYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<SalesByCategoryResult>("EXEC @returnValue = [dbo].[SalesByCategory] @CategoryName = @CategoryName, @OrdYear = @OrdYear", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_Employees_CursorResult>> sp_Employees_CursorAsync(string CityIn, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "CityIn",
                    Size = 30,
                    Value = CityIn ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_Employees_CursorResult>("EXEC @returnValue = [dbo].[sp_Employees_Cursor] @CityIn = @CityIn", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> sp_Employees_InsertAsync(string LastName, string FirstName, string Title, string TitleOfCourtesy, DateTime? BirthDate, DateTime? HireDate, string Address, string City, string Region, string PostalCode, string Country, string HomePhone, string Extension, byte[] Photo, string Notes, int? ReportsTo, OutputParameter<int?> ReturnID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterReturnID = new SqlParameter
            {
                ParameterName = "ReturnID",
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = ReturnID?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "LastName",
                    Size = 2,
                    Value = LastName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "FirstName",
                    Size = 2,
                    Value = FirstName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Title",
                    Size = 2,
                    Value = Title ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "TitleOfCourtesy",
                    Size = 2,
                    Value = TitleOfCourtesy ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "BirthDate",
                    Value = BirthDate ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "HireDate",
                    Value = HireDate ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "Address",
                    Size = 2,
                    Value = Address ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "City",
                    Size = 2,
                    Value = City ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Region",
                    Size = 2,
                    Value = Region ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "PostalCode",
                    Size = 2,
                    Value = PostalCode ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Country",
                    Size = 2,
                    Value = Country ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "HomePhone",
                    Size = 2,
                    Value = HomePhone ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Extension",
                    Size = 2,
                    Value = Extension ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Photo",
                    Value = Photo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Image,
                },
                new SqlParameter
                {
                    ParameterName = "Notes",
                    Value = Notes ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NText,
                },
                new SqlParameter
                {
                    ParameterName = "ReportsTo",
                    Value = ReportsTo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterReturnID,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_Employees_Insert] @LastName = @LastName, @FirstName = @FirstName, @Title = @Title, @TitleOfCourtesy = @TitleOfCourtesy, @BirthDate = @BirthDate, @HireDate = @HireDate, @Address = @Address, @City = @City, @Region = @Region, @PostalCode = @PostalCode, @Country = @Country, @HomePhone = @HomePhone, @Extension = @Extension, @Photo = @Photo, @Notes = @Notes, @ReportsTo = @ReportsTo, @ReturnID = @ReturnID OUTPUT", sqlParameters, cancellationToken);

            ReturnID?.SetValue(parameterReturnID.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_employees_rankResult>> sp_employees_rankAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_employees_rankResult>("EXEC @returnValue = [dbo].[sp_employees_rank]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_employees_rollupResult>> sp_employees_rollupAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_employees_rollupResult>("EXEC @returnValue = [dbo].[sp_employees_rollup]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_employees_rownumResult>> sp_employees_rownumAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_employees_rownumResult>("EXEC @returnValue = [dbo].[sp_employees_rownum]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_Employees_SelectAllResult>> sp_Employees_SelectAllAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_Employees_SelectAllResult>("EXEC @returnValue = [dbo].[sp_Employees_SelectAll]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_Employees_SelectRowResult>> sp_Employees_SelectRowAsync(int? EmployeeID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "EmployeeID",
                    Value = EmployeeID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_Employees_SelectRowResult>("EXEC @returnValue = [dbo].[sp_Employees_SelectRow] @EmployeeID = @EmployeeID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> sp_Employees_UpdateAsync(int? EmployeeID, string LastName, string FirstName, string Title, string TitleOfCourtesy, DateTime? BirthDate, DateTime? HireDate, string Address, string City, string Region, string PostalCode, string Country, string HomePhone, string Extension, byte[] Photo, string Notes, int? ReportsTo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "EmployeeID",
                    Value = EmployeeID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "LastName",
                    Size = 2,
                    Value = LastName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "FirstName",
                    Size = 2,
                    Value = FirstName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Title",
                    Size = 2,
                    Value = Title ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "TitleOfCourtesy",
                    Size = 2,
                    Value = TitleOfCourtesy ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "BirthDate",
                    Value = BirthDate ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "HireDate",
                    Value = HireDate ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "Address",
                    Size = 2,
                    Value = Address ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "City",
                    Size = 2,
                    Value = City ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Region",
                    Size = 2,
                    Value = Region ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "PostalCode",
                    Size = 2,
                    Value = PostalCode ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Country",
                    Size = 2,
                    Value = Country ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "HomePhone",
                    Size = 2,
                    Value = HomePhone ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Extension",
                    Size = 2,
                    Value = Extension ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Photo",
                    Value = Photo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Image,
                },
                new SqlParameter
                {
                    ParameterName = "Notes",
                    Value = Notes ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NText,
                },
                new SqlParameter
                {
                    ParameterName = "ReportsTo",
                    Value = ReportsTo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_Employees_Update] @EmployeeID = @EmployeeID, @LastName = @LastName, @FirstName = @FirstName, @Title = @Title, @TitleOfCourtesy = @TitleOfCourtesy, @BirthDate = @BirthDate, @HireDate = @HireDate, @Address = @Address, @City = @City, @Region = @Region, @PostalCode = @PostalCode, @Country = @Country, @HomePhone = @HomePhone, @Extension = @Extension, @Photo = @Photo, @Notes = @Notes, @ReportsTo = @ReportsTo", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<TenMostExpensiveProductsResult>> TenMostExpensiveProductsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<TenMostExpensiveProductsResult>("EXEC @returnValue = [dbo].[Ten Most Expensive Products]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
