using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crudmvc.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }
    }
}
