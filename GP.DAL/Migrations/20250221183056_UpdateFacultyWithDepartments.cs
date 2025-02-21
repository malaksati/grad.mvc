using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.DAL.Migrations
{
    public partial class UpdateFacultyWithDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        UPDATE FacultyMembers
        SET DeptId = 
            CASE 
                WHEN Id = 4 THEN 1
                WHEN Id = 5 THEN 3
                WHEN Id = 6 THEN 2
                WHEN Id = 7 THEN 4
                WHEN Id = 8 THEN 5
                WHEN Id = 9 THEN 6
                WHEN Id = 10 THEN 7
                WHEN Id = 11 THEN 8
                WHEN Id = 12 THEN 9
                WHEN Id = 13 THEN 10
                ELSE DeptId
            END
        WHERE Id BETWEEN 4 AND 13;
    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
