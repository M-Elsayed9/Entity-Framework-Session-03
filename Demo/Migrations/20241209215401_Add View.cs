using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(("CREATE VIEW [dbo].[vwEmployee] AS SELECT [e].[Id], [e].[Name], [e].[Salary], [e].[Address], [d].[Name] AS [DepartmentName] FROM [dbo].[Employees] AS [e] INNER JOIN [dbo].[Departments] AS [d] ON [e].[DepartmentId] = [d].[Id]"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW [dbo].[vwEmployee]");
        }
    }
}
