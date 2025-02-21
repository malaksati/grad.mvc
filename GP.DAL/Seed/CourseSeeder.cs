using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public class CourseSeeder
    {
        public static List<Course> GenerateCourses()
        {
            return new List<Course>
        {
            new() { Code = "BS111", Name = "English Language 1", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "BS112", Name = "English Language 2", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "BS114", Name = "Technical Report Writing", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "CS111", Name = "Introduction to Computer Science", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "BS151", Name = "Linear Algebra 1", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "BS152", Name = "Linear Algebra 2", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "BS153", Name = "Mathematical Analysis 1", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
            new() { Code = "BS154", Name = "Mathematical Analysis 2", CreditHour = 3, NoOfSec = 2, NoOfLec = 2, DeptId = 11 },
        };
        }

        public static List<CoursePrerequisite> GeneratePrerequisites()
        {
            return new List<CoursePrerequisite>
        {
            new() { CourseCode = "BS112", PrerequisiteCode = "BS111" },
            new() { CourseCode = "BS152", PrerequisiteCode = "BS151" },
            new() { CourseCode = "BS154", PrerequisiteCode = "BS153" }
        };
        }
    }
}
