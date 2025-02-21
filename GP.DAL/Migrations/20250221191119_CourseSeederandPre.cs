using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.DAL.Migrations
{
    public partial class CourseSeederandPre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Code", "CreditHour", "DeptId", "Name", "NoOfLec", "NoOfSec" },
                values: new object[,]
                {
                    { "BS111", 3, 11, "English Language 1", 2, 2 },
                    { "BS112", 3, 11, "English Language 2", 2, 2 },
                    { "BS114", 3, 11, "Technical Report Writing", 2, 2 },
                    { "BS151", 3, 11, "Linear Algebra 1", 2, 2 },
                    { "BS152", 3, 11, "Linear Algebra 2", 2, 2 },
                    { "BS153", 3, 11, "Mathematical Analysis 1", 2, 2 },
                    { "BS154", 3, 11, "Mathematical Analysis 2", 2, 2 },
                    { "CS111", 3, 11, "Introduction to Computer Science", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CoursePrerequisite",
                columns: new[] { "CourseCode", "PrerequisiteCode" },
                values: new object[] { "BS112", "BS111" });

            migrationBuilder.InsertData(
                table: "CoursePrerequisite",
                columns: new[] { "CourseCode", "PrerequisiteCode" },
                values: new object[] { "BS152", "BS151" });

            migrationBuilder.InsertData(
                table: "CoursePrerequisite",
                columns: new[] { "CourseCode", "PrerequisiteCode" },
                values: new object[] { "BS154", "BS153" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoursePrerequisite",
                keyColumns: new[] { "CourseCode", "PrerequisiteCode" },
                keyValues: new object[] { "BS112", "BS111" });

            migrationBuilder.DeleteData(
                table: "CoursePrerequisite",
                keyColumns: new[] { "CourseCode", "PrerequisiteCode" },
                keyValues: new object[] { "BS152", "BS151" });

            migrationBuilder.DeleteData(
                table: "CoursePrerequisite",
                keyColumns: new[] { "CourseCode", "PrerequisiteCode" },
                keyValues: new object[] { "BS154", "BS153" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS114");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "CS111");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS111");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS112");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS151");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS152");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS153");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Code",
                keyValue: "BS154");
        }
    }
}
