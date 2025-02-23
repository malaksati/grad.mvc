using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public class DbInitializer
    {
        public static void SeedAdvisor(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "advisor.json");
            if (!context.Advisors.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Advisor>>(jsonData);

                if (rooms != null)
                {
                    context.Advisors.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedCollege(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "college.json");
            if (!context.Colleges.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<College>>(jsonData);

                if (rooms != null)
                {
                    context.Colleges.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedFacultyWithoutDept(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "facultymemberswithoutdept.json");
            if (!context.FacultyMembers.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<FacultyMember>>(jsonData);

                if (rooms != null)
                {
                    context.FacultyMembers.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedFacultyWithDept(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "facultymemberswithdep.json");
            if (!context.FacultyMembers.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<FacultyMember>>(jsonData);

                if (rooms != null)
                {
                    context.FacultyMembers.UpdateRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedDapertment(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "departments.json");
            if (!context.Departments.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Department>>(jsonData);

                if (rooms != null)
                {
                    context.Departments.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedCourses(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "courses.json");
            if (!context.Courses.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Course>>(jsonData);

                if (rooms != null)
                {
                    context.Courses.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedCoursesPre(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "courseprerequists.json");
            if (!context.CoursePrerequisites.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<CoursePrerequisite>>(jsonData);

                if (rooms != null)
                {
                    context.CoursePrerequisites.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedPlace(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "places.json");
            if (!context.Places.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Place>>(jsonData);

                if (rooms != null)
                {
                    context.Places.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedFollowUp(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "followups.json");
            if (!context.FollowUps.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<FollowUp>>(jsonData);

                if (rooms != null)
                {
                    context.FollowUps.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedStudentAffairs(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "studentaffairs.json");
            if (!context.StudentAffairs.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<StudentAffairs>>(jsonData);

                if (rooms != null)
                {
                    context.StudentAffairs.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedFinancialAffairs(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "financialaffairs.json");
            if (!context.StudentAffairs.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<StudentAffairs>>(jsonData);

                if (rooms != null)
                {
                    context.StudentAffairs.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
    }
}
