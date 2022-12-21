using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CompanyName", "DepartmentId", "OrganisationNumber" },
                values: new object[,]
                {
                    { 1, "Namco", null, "89323212" },
                    { 2, "Alibaba", null, "42342342" },
                    { 3, "Samsung", null, "64363884" },
                    { 4, "Tesla", null, "88999123" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "PositionName" },
                values: new object[,]
                {
                    { 1, "CEO" },
                    { 2, "Game DEV" },
                    { 3, "FrontDEV" },
                    { 4, "BackDEV" },
                    { 5, "FullstackDEV" },
                    { 6, "BuisnessChief" },
                    { 7, "UX Desginer" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CompanyId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, 1, "DEV" },
                    { 2, 1, "Buisness" },
                    { 3, 2, "DEV" },
                    { 4, 2, "Buisness" },
                    { 5, 2, "HardWare" },
                    { 6, 3, "Buisness" },
                    { 7, 3, "DEV" },
                    { 8, 3, "HardWare" },
                    { 9, 4, "HardWare" },
                    { 10, 4, "Buisness" },
                    { 11, 4, "DEV" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "Salary", "Union" },
                values: new object[,]
                {
                    { 1, 1, "Katsuhiro", "Harada", 2500000m, true },
                    { 2, 1, "Seiichi", "Ishii", 100000000m, true },
                    { 3, 11, "Elon", "Musk", 1000000000m, true },
                    { 4, 5, "Jack", "Ma", 100000000m, true }
                });

            migrationBuilder.InsertData(
                table: "Employeeposition",
                columns: new[] { "EmployeeId", "PositionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 5 },
                    { 2, 2 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Employeeposition",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
