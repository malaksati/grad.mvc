using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.DAL.Migrations
{
    public partial class PlaceAdvisorFollowUpSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "FirstName", "Gender", "LastName", "MiddleName", "MobilePhone", "SSN", "Salary" },
                values: new object[,]
                {
                    { 1, "Cairo, Maadi", "Mohamed", 0, "Mostafa", "Ahmed", "01234567890", "1234567890123456", 5000.0 },
                    { 2, "Cairo, Mokattam", "Jana", 1, "Ali", "Mohamed", "01123456789", "9876543210987654", 5500.5 },
                    { 3, "Giza, Dokki", "Omar", 0, "Hassan", "Ibrahim", "01098765432", "1122334455667788", 4800.0 },
                    { 4, "Alexandria, Sidi Gaber", "Sara", 1, "Adel", "Mostafa", "01211223344", "2233445566778899", 5200.75 },
                    { 5, "Mansoura, Talkha", "Hassan", 0, "Kamal", "Amr", "01555667788", "3344556677889900", 4900.25 }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "40", true, "Sec1", "Ex" },
                    { 2, "40", true, "Sec2", "Ex" },
                    { 3, "40", true, "Sec3", "Ex" },
                    { 4, "40", true, "Sec4", "Ex" },
                    { 5, "40", true, "Sec5", "Ex" },
                    { 6, "40", true, "Sec6", "Ex" },
                    { 7, "40", true, "Sec7", "Ex" },
                    { 8, "40", true, "Sec8", "Ex" },
                    { 9, "40", true, "Sec9", "Ex" },
                    { 10, "40", true, "Sec10", "Ex" },
                    { 11, "40", true, "Sec11", "Ex" },
                    { 12, "40", true, "Sec12", "Ex" },
                    { 13, "28", true, "Lab1", "Lab" },
                    { 14, "28", true, "Lab2", "Lab" },
                    { 15, "28", true, "Lab3", "Lab" },
                    { 16, "28", true, "Lab4", "Lab" },
                    { 17, "28", true, "Lab5", "Lab" },
                    { 18, "28", true, "Lab6", "Lab" },
                    { 19, "200", true, "L1", "L" },
                    { 20, "200", true, "L2", "L" },
                    { 21, "200", true, "L3", "L" },
                    { 23, "28", true, "Sec1/Lab1", "Ex/Lab" },
                    { 24, "28", true, "Sec1/Lab2", "Ex/Lab" },
                    { 25, "28", true, "Sec1/Lab3", "Ex/Lab" },
                    { 26, "28", true, "Sec1/Lab4", "Ex/Lab" },
                    { 27, "28", true, "Sec1/Lab5", "Ex/Lab" },
                    { 28, "28", true, "Sec1/Lab6", "Ex/Lab" },
                    { 29, "28", true, "Sec2/Lab1", "Ex/Lab" },
                    { 30, "28", true, "Sec2/Lab2", "Ex/Lab" },
                    { 31, "28", true, "Sec2/Lab3", "Ex/Lab" },
                    { 32, "28", true, "Sec2/Lab4", "Ex/Lab" },
                    { 33, "28", true, "Sec2/Lab5", "Ex/Lab" },
                    { 34, "28", true, "Sec2/Lab6", "Ex/Lab" },
                    { 35, "28", true, "Sec3/Lab1", "Ex/Lab" },
                    { 36, "28", true, "Sec3/Lab2", "Ex/Lab" },
                    { 37, "28", true, "Sec3/Lab3", "Ex/Lab" },
                    { 38, "28", true, "Sec3/Lab4", "Ex/Lab" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Type" },
                values: new object[,]
                {
                    { 39, "28", true, "Sec3/Lab5", "Ex/Lab" },
                    { 40, "28", true, "Sec3/Lab6", "Ex/Lab" },
                    { 41, "28", true, "Sec4/Lab1", "Ex/Lab" },
                    { 42, "28", true, "Sec4/Lab2", "Ex/Lab" },
                    { 43, "28", true, "Sec4/Lab3", "Ex/Lab" },
                    { 44, "28", true, "Sec4/Lab4", "Ex/Lab" },
                    { 45, "28", true, "Sec4/Lab5", "Ex/Lab" },
                    { 46, "28", true, "Sec4/Lab6", "Ex/Lab" },
                    { 47, "28", true, "Sec5/Lab1", "Ex/Lab" },
                    { 48, "28", true, "Sec5/Lab2", "Ex/Lab" },
                    { 49, "28", true, "Sec5/Lab3", "Ex/Lab" },
                    { 50, "28", true, "Sec5/Lab4", "Ex/Lab" },
                    { 51, "28", true, "Sec5/Lab5", "Ex/Lab" },
                    { 52, "28", true, "Sec5/Lab6", "Ex/Lab" },
                    { 53, "28", true, "Sec6/Lab1", "Ex/Lab" },
                    { 54, "28", true, "Sec6/Lab2", "Ex/Lab" },
                    { 55, "28", true, "Sec6/Lab3", "Ex/Lab" },
                    { 56, "28", true, "Sec6/Lab4", "Ex/Lab" },
                    { 57, "28", true, "Sec6/Lab5", "Ex/Lab" },
                    { 58, "28", true, "Sec6/Lab6", "Ex/Lab" },
                    { 59, "28", true, "Sec7/Lab1", "Ex/Lab" },
                    { 60, "28", true, "Sec7/Lab2", "Ex/Lab" },
                    { 61, "28", true, "Sec7/Lab3", "Ex/Lab" },
                    { 62, "28", true, "Sec7/Lab4", "Ex/Lab" },
                    { 63, "28", true, "Sec7/Lab5", "Ex/Lab" },
                    { 64, "28", true, "Sec7/Lab6", "Ex/Lab" },
                    { 65, "28", true, "Sec8/Lab1", "Ex/Lab" },
                    { 66, "28", true, "Sec8/Lab2", "Ex/Lab" },
                    { 67, "28", true, "Sec8/Lab3", "Ex/Lab" },
                    { 68, "28", true, "Sec8/Lab4", "Ex/Lab" },
                    { 69, "28", true, "Sec8/Lab5", "Ex/Lab" },
                    { 70, "28", true, "Sec8/Lab6", "Ex/Lab" },
                    { 71, "28", true, "Sec9/Lab1", "Ex/Lab" },
                    { 72, "28", true, "Sec9/Lab2", "Ex/Lab" },
                    { 73, "28", true, "Sec9/Lab3", "Ex/Lab" },
                    { 74, "28", true, "Sec9/Lab4", "Ex/Lab" },
                    { 75, "28", true, "Sec9/Lab5", "Ex/Lab" },
                    { 76, "28", true, "Sec9/Lab6", "Ex/Lab" },
                    { 77, "28", true, "Sec10/Lab1", "Ex/Lab" },
                    { 78, "28", true, "Sec10/Lab2", "Ex/Lab" },
                    { 79, "28", true, "Sec10/Lab3", "Ex/Lab" },
                    { 80, "28", true, "Sec10/Lab4", "Ex/Lab" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Type" },
                values: new object[,]
                {
                    { 81, "28", true, "Sec10/Lab5", "Ex/Lab" },
                    { 82, "28", true, "Sec10/Lab6", "Ex/Lab" },
                    { 83, "28", true, "Sec11/Lab1", "Ex/Lab" },
                    { 84, "28", true, "Sec11/Lab2", "Ex/Lab" },
                    { 85, "28", true, "Sec11/Lab3", "Ex/Lab" },
                    { 86, "28", true, "Sec11/Lab4", "Ex/Lab" },
                    { 87, "28", true, "Sec11/Lab5", "Ex/Lab" },
                    { 88, "28", true, "Sec11/Lab6", "Ex/Lab" },
                    { 89, "28", true, "Sec12/Lab1", "Ex/Lab" },
                    { 90, "28", true, "Sec12/Lab2", "Ex/Lab" },
                    { 91, "28", true, "Sec12/Lab3", "Ex/Lab" },
                    { 92, "28", true, "Sec12/Lab4", "Ex/Lab" },
                    { 93, "28", true, "Sec12/Lab5", "Ex/Lab" },
                    { 94, "28", true, "Sec12/Lab6", "Ex/Lab" },
                    { 95, "40", true, "Sec1/Lab1", "Ex/Lab" },
                    { 96, "40", true, "Sec1/Lab2", "Ex/Lab" },
                    { 97, "40", true, "Sec1/Lab3", "Ex/Lab" },
                    { 98, "40", true, "Sec1/Lab4", "Ex/Lab" },
                    { 99, "40", true, "Sec1/Lab5", "Ex/Lab" },
                    { 100, "40", true, "Sec1/Lab6", "Ex/Lab" },
                    { 101, "40", true, "Sec2/Lab1", "Ex/Lab" },
                    { 102, "40", true, "Sec2/Lab2", "Ex/Lab" },
                    { 103, "40", true, "Sec2/Lab3", "Ex/Lab" },
                    { 104, "40", true, "Sec2/Lab4", "Ex/Lab" },
                    { 105, "40", true, "Sec2/Lab5", "Ex/Lab" },
                    { 106, "40", true, "Sec2/Lab6", "Ex/Lab" },
                    { 107, "40", true, "Sec3/Lab1", "Ex/Lab" },
                    { 108, "40", true, "Sec3/Lab2", "Ex/Lab" },
                    { 109, "40", true, "Sec3/Lab3", "Ex/Lab" },
                    { 110, "40", true, "Sec3/Lab4", "Ex/Lab" },
                    { 111, "40", true, "Sec3/Lab5", "Ex/Lab" },
                    { 112, "40", true, "Sec3/Lab6", "Ex/Lab" },
                    { 113, "40", true, "Sec4/Lab1", "Ex/Lab" },
                    { 114, "40", true, "Sec4/Lab2", "Ex/Lab" },
                    { 115, "40", true, "Sec4/Lab3", "Ex/Lab" },
                    { 116, "40", true, "Sec4/Lab4", "Ex/Lab" },
                    { 117, "40", true, "Sec4/Lab5", "Ex/Lab" },
                    { 118, "40", true, "Sec4/Lab6", "Ex/Lab" },
                    { 119, "40", true, "Sec5/Lab1", "Ex/Lab" },
                    { 120, "40", true, "Sec5/Lab2", "Ex/Lab" },
                    { 121, "40", true, "Sec5/Lab3", "Ex/Lab" },
                    { 122, "40", true, "Sec5/Lab4", "Ex/Lab" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Type" },
                values: new object[,]
                {
                    { 123, "40", true, "Sec5/Lab5", "Ex/Lab" },
                    { 124, "40", true, "Sec5/Lab6", "Ex/Lab" },
                    { 125, "40", true, "Sec6/Lab1", "Ex/Lab" },
                    { 126, "40", true, "Sec6/Lab2", "Ex/Lab" },
                    { 127, "40", true, "Sec6/Lab3", "Ex/Lab" },
                    { 128, "40", true, "Sec6/Lab4", "Ex/Lab" },
                    { 129, "40", true, "Sec6/Lab5", "Ex/Lab" },
                    { 130, "40", true, "Sec6/Lab6", "Ex/Lab" },
                    { 131, "40", true, "Sec7/Lab1", "Ex/Lab" },
                    { 132, "40", true, "Sec7/Lab2", "Ex/Lab" },
                    { 133, "40", true, "Sec7/Lab3", "Ex/Lab" },
                    { 134, "40", true, "Sec7/Lab4", "Ex/Lab" },
                    { 135, "40", true, "Sec7/Lab5", "Ex/Lab" },
                    { 136, "40", true, "Sec7/Lab6", "Ex/Lab" },
                    { 137, "40", true, "Sec8/Lab1", "Ex/Lab" },
                    { 138, "40", true, "Sec8/Lab2", "Ex/Lab" },
                    { 139, "40", true, "Sec8/Lab3", "Ex/Lab" },
                    { 140, "40", true, "Sec8/Lab4", "Ex/Lab" },
                    { 141, "40", true, "Sec8/Lab5", "Ex/Lab" },
                    { 142, "40", true, "Sec8/Lab6", "Ex/Lab" },
                    { 143, "40", true, "Sec9/Lab1", "Ex/Lab" },
                    { 144, "40", true, "Sec9/Lab2", "Ex/Lab" },
                    { 145, "40", true, "Sec9/Lab3", "Ex/Lab" },
                    { 146, "40", true, "Sec9/Lab4", "Ex/Lab" },
                    { 147, "40", true, "Sec9/Lab5", "Ex/Lab" },
                    { 148, "40", true, "Sec9/Lab6", "Ex/Lab" },
                    { 149, "40", true, "Sec10/Lab1", "Ex/Lab" },
                    { 150, "40", true, "Sec10/Lab2", "Ex/Lab" },
                    { 151, "40", true, "Sec10/Lab3", "Ex/Lab" },
                    { 152, "40", true, "Sec10/Lab4", "Ex/Lab" },
                    { 153, "40", true, "Sec10/Lab5", "Ex/Lab" },
                    { 154, "40", true, "Sec10/Lab6", "Ex/Lab" },
                    { 155, "40", true, "Sec11/Lab1", "Ex/Lab" },
                    { 156, "40", true, "Sec11/Lab2", "Ex/Lab" },
                    { 157, "40", true, "Sec11/Lab3", "Ex/Lab" },
                    { 158, "40", true, "Sec11/Lab4", "Ex/Lab" },
                    { 159, "40", true, "Sec11/Lab5", "Ex/Lab" },
                    { 160, "40", true, "Sec11/Lab6", "Ex/Lab" },
                    { 161, "40", true, "Sec12/Lab1", "Ex/Lab" },
                    { 162, "40", true, "Sec12/Lab2", "Ex/Lab" },
                    { 163, "40", true, "Sec12/Lab3", "Ex/Lab" },
                    { 164, "40", true, "Sec12/Lab4", "Ex/Lab" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Type" },
                values: new object[,]
                {
                    { 165, "40", true, "Sec12/Lab5", "Ex/Lab" },
                    { 166, "40", true, "Sec12/Lab6", "Ex/Lab" },
                    { 167, "40", true, "L1/Sec1", "L/Ex" },
                    { 168, "40", true, "L1/Sec2", "L/Ex" },
                    { 169, "40", true, "L1/Sec3", "L/Ex" },
                    { 170, "40", true, "L1/Sec4", "L/Ex" },
                    { 171, "40", true, "L1/Sec5", "L/Ex" },
                    { 172, "40", true, "L1/Sec6", "L/Ex" },
                    { 173, "40", true, "L1/Sec7", "L/Ex" },
                    { 174, "40", true, "L1/Sec8", "L/Ex" },
                    { 175, "40", true, "L1/Sec9", "L/Ex" },
                    { 176, "40", true, "L1/Sec10", "L/Ex" },
                    { 177, "40", true, "L1/Sec11", "L/Ex" },
                    { 178, "40", true, "L1/Sec12", "L/Ex" },
                    { 179, "40", true, "L2/Sec1", "L/Ex" },
                    { 180, "40", true, "L2/Sec2", "L/Ex" },
                    { 181, "40", true, "L2/Sec3", "L/Ex" },
                    { 182, "40", true, "L2/Sec4", "L/Ex" },
                    { 183, "40", true, "L2/Sec5", "L/Ex" },
                    { 184, "40", true, "L2/Sec6", "L/Ex" },
                    { 185, "40", true, "L2/Sec7", "L/Ex" },
                    { 186, "40", true, "L2/Sec8", "L/Ex" },
                    { 187, "40", true, "L2/Sec9", "L/Ex" },
                    { 188, "40", true, "L2/Sec10", "L/Ex" },
                    { 189, "40", true, "L2/Sec11", "L/Ex" },
                    { 190, "40", true, "L2/Sec12", "L/Ex" },
                    { 191, "40", true, "L3/Sec1", "L/Ex" },
                    { 192, "40", true, "L3/Sec2", "L/Ex" },
                    { 193, "40", true, "L3/Sec3", "L/Ex" },
                    { 194, "40", true, "L3/Sec4", "L/Ex" },
                    { 195, "40", true, "L3/Sec5", "L/Ex" },
                    { 196, "40", true, "L3/Sec6", "L/Ex" },
                    { 197, "40", true, "L3/Sec7", "L/Ex" },
                    { 198, "40", true, "L3/Sec8", "L/Ex" },
                    { 199, "40", true, "L3/Sec9", "L/Ex" },
                    { 200, "40", true, "L3/Sec10", "L/Ex" },
                    { 201, "40", true, "L3/Sec11", "L/Ex" },
                    { 202, "40", true, "L3/Sec12", "L/Ex" },
                    { 203, "200", true, "L1/Sec1", "L/Ex" },
                    { 204, "200", true, "L1/Sec2", "L/Ex" },
                    { 205, "200", true, "L1/Sec3", "L/Ex" },
                    { 206, "200", true, "L1/Sec4", "L/Ex" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Name", "Type" },
                values: new object[,]
                {
                    { 207, "200", true, "L1/Sec5", "L/Ex" },
                    { 208, "200", true, "L1/Sec6", "L/Ex" },
                    { 209, "200", true, "L1/Sec7", "L/Ex" },
                    { 210, "200", true, "L1/Sec8", "L/Ex" },
                    { 211, "200", true, "L1/Sec9", "L/Ex" },
                    { 212, "200", true, "L1/Sec10", "L/Ex" },
                    { 213, "200", true, "L1/Sec11", "L/Ex" },
                    { 214, "200", true, "L1/Sec12", "L/Ex" },
                    { 215, "200", true, "L2/Sec1", "L/Ex" },
                    { 216, "200", true, "L2/Sec2", "L/Ex" },
                    { 217, "200", true, "L2/Sec3", "L/Ex" },
                    { 218, "200", true, "L2/Sec4", "L/Ex" },
                    { 219, "200", true, "L2/Sec5", "L/Ex" },
                    { 220, "200", true, "L2/Sec6", "L/Ex" },
                    { 221, "200", true, "L2/Sec7", "L/Ex" },
                    { 222, "200", true, "L2/Sec8", "L/Ex" },
                    { 223, "200", true, "L2/Sec9", "L/Ex" },
                    { 224, "200", true, "L2/Sec10", "L/Ex" },
                    { 225, "200", true, "L2/Sec11", "L/Ex" },
                    { 226, "200", true, "L2/Sec12", "L/Ex" },
                    { 227, "200", true, "L3/Sec1", "L/Ex" },
                    { 228, "200", true, "L3/Sec2", "L/Ex" },
                    { 229, "200", true, "L3/Sec3", "L/Ex" },
                    { 230, "200", true, "L3/Sec4", "L/Ex" },
                    { 231, "200", true, "L3/Sec5", "L/Ex" },
                    { 232, "200", true, "L3/Sec6", "L/Ex" },
                    { 233, "200", true, "L3/Sec7", "L/Ex" },
                    { 234, "200", true, "L3/Sec8", "L/Ex" },
                    { 235, "200", true, "L3/Sec9", "L/Ex" },
                    { 236, "200", true, "L3/Sec10", "L/Ex" },
                    { 237, "200", true, "L3/Sec11", "L/Ex" },
                    { 238, "200", true, "L3/Sec12", "L/Ex" }
                });

            migrationBuilder.InsertData(
                table: "Advisors",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "FollowUps",
                column: "Id",
                values: new object[]
                {
                    3,
                    4,
                    5
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advisors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advisors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FollowUps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FollowUps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FollowUps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
