using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.DAL.Migrations
{
    public partial class StudentAndFinancialAffairsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "FirstName", "Gender", "LastName", "MiddleName", "MobilePhone", "SSN", "Salary" },
                values: new object[,]
                {
                    { 9, "Giza, Haram", "Mona", 1, "Ibrahim", "Hassan", "01266778899", "6677889900112233", 5300.75 },
                    { 10, "Mansoura, Aga", "Omar", 0, "Saad", "Nour", "01577889900", "7788690011203344", 5500.0 },
                    { 11, "Mansoura, Aga", "Hamed", 0, "Saad", "Mohamed", "01577889900", "7783990011228344", 5500.0 },
                    { 6, "Cairo, Nasr City", "Ali", 0, "Mahmoud", "Youssef", "01022334455", "4455667788990011", 4700.0 },
                    { 7, "Alexandria, Smouha", "Laila", 1, "Nabil", "Karim", "01155667788", "5566778899081122", 4800.5 },
                    { 8, "Alexandria, Smouha", "Dana", 1, "Mohamed", "Karim", "01155667788", "5562778899001122", 4800.5 }
                });

            migrationBuilder.InsertData(
                table: "FinancialAffairs",
                columns: new[] { "Id", "ManagerId" },
                values: new object[] { 9, null });

            migrationBuilder.InsertData(
                table: "StudentAffairs",
                columns: new[] { "Id", "ManagerId" },
                values: new object[] { 6, null });

            migrationBuilder.InsertData(
                table: "FinancialAffairs",
                columns: new[] { "Id", "ManagerId" },
                values: new object[,]
                {
                    { 10, 9 },
                    { 11, 9 }
                });

            migrationBuilder.InsertData(
                table: "StudentAffairs",
                columns: new[] { "Id", "ManagerId" },
                values: new object[,]
                {
                    { 7, 6 },
                    { 8, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FinancialAffairs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FinancialAffairs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentAffairs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentAffairs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FinancialAffairs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentAffairs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
