using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Attachment.Migrations
{
    public partial class AddEmpV2Seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAOn",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CreatedAOn", "Email", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 1, 44, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "razhog@gmail.com", "Raziyah", "Hogans", "202-333-4444", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CreatedAOn", "Email", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 2, 44, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "mfrank@gmail.com", "Mike", "Franklin", "202-561-2367", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CreatedAOn", "Email", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 3, 44, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "jsmith@gmail.com", "John", "Smith", "202-723-4434", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedAOn",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
