using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class EditedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefusedOvertime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TotalOvertime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WeekEnding",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkedOvertime",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RefusedOvertime",
                table: "Employees",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalOvertime",
                table: "Employees",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "WeekEnding",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "WorkedOvertime",
                table: "Employees",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
