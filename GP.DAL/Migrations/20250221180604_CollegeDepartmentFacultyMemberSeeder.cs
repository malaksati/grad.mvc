using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.DAL.Migrations
{
    public partial class CollegeDepartmentFacultyMemberSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FacultyMembers",
                columns: new[] { "Id", "Address", "DeptId", "FirstName", "LastName", "MiddleName", "MobilePhone", "SSN", "WorkingHours" },
                values: new object[,]
                {
                    { 1, "Cairo, Nasr City", null, "Reham", "Momtaz", "Ibrahem", "01012345678", "1111322233334444", 3 },
                    { 2, "Giza, Dokki", null, "Mohamed", "Mayah", "El", "01198765432", "5555666677578888", 3 },
                    { 3, "Alexandria, Smouha", null, "Shohda", "Maraghy", "El", "01234567890", "9919000011112222", 3 },
                    { 4, "Mansoura, Aga", null, "Hanafy", "Ismail", "Mahmoud", "01556789012", "2222333344345555", 6 },
                    { 5, "Fayoum, Senouras", null, "Hafez", "ElWahab", "Abd", "01087654321", "6666770788889999", 6 },
                    { 6, "Fayoum, Senouras", null, "Hesham", "El-Deeb", "Mohamed", "01087654321", "6666777788869999", 6 },
                    { 7, "Fayoum, Senouras", null, "Elsayed", "Soleit", "Abdel Aziz", "01087654321", "6666737788869999", 6 },
                    { 8, "Mansoura, Aga", null, "Mohammed", "El Fawal", "Mahmoud", "01556789012", "2222373344345555", 6 },
                    { 9, "Mansoura, Aga", null, "Mona", "Mehanna", "Samir", "01556789012", "2222373344343555", 6 },
                    { 10, "Mansoura, Aga", null, "Eman", "Omar", "Mokhtar", "01556789012", "2272373344034355", 6 },
                    { 11, "Mansoura, Aga", null, "Dalia", "Mohamed", "Adel", "01556289012", "2272303544034355", 6 },
                    { 12, "Cairo, Nasr City", null, "Tamer", "Nasr", "Mohamed", "01012345678", "1101322233334444", 6 },
                    { 13, "Cairo, Nasr City", null, "Nesreen", "Omar", "Nabil", "01012345678", "1101322233333444", 6 }
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "DeanId", "Name" },
                values: new object[] { 1, 1, "Engineering" });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "DeanId", "Name" },
                values: new object[] { 2, 2, "Computers and Artificial Intelligence" });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "DeanId", "Name" },
                values: new object[] { 3, 3, "Pharmacy" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CollegeId", "HeadId", "Name" },
                values: new object[,]
                {
                    { 1, 2, 4, "Computer Science" },
                    { 2, 2, 6, "Artificial Intelligence" },
                    { 3, 2, 5, "Information Systems" },
                    { 4, 1, 7, "Electrical Engineering" },
                    { 5, 1, 8, "Mechnical Engineering" },
                    { 6, 1, 9, "Physics and Mathematical Engineering" },
                    { 7, 1, 10, "Architectural Engineering" },
                    { 8, 3, 11, "Pharmacognosy" },
                    { 9, 3, 12, "Pharmaceutical Chemistry" },
                    { 10, 3, 13, "Biochemistry" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FacultyMembers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
