using GP.DAL.Context;
using GP.DAL.Dto;
using GP.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

                var managers = rooms.Where(r => r.ManagerId == null).ToList();
                var employees = rooms.Where(r => r.ManagerId != null).ToList();

                context.StudentAffairs.AddRange(managers);
                context.SaveChanges(); // Ensure managers get their IDs

                foreach (var employee in employees)
                {
                    var manager = context.StudentAffairs.FirstOrDefault(m => m.Id == employee.ManagerId);
                    if (manager != null)
                        employee.ManagerId = manager.Id;
                }

                context.StudentAffairs.AddRange(employees);
                context.SaveChanges();
            }
        }
        public static void SeedFinancialAffairs(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "financialaffairs.json");
            if (!context.FinancialAffairs.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<FinancialAffairs>>(jsonData);

                var managers = rooms.Where(r => r.ManagerId == null).ToList();
                var employees = rooms.Where(r => r.ManagerId != null).ToList();

                context.FinancialAffairs.AddRange(managers);
                context.SaveChanges(); // Ensure managers get their IDs

                foreach (var employee in employees)
                {
                    var manager = context.FinancialAffairs.FirstOrDefault(m => m.Id == employee.ManagerId);
                    if (manager != null)
                        employee.ManagerId = manager.Id;
                }

                context.FinancialAffairs.AddRange(employees);
                context.SaveChanges();
            }
        }
        public static void SeedStudents(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "students.json");

            if (!context.Students.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);

                var studentsDto = JsonSerializer.Deserialize<List<StudentDTO>>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                // Convert DTOs to actual Student entities
                var students = studentsDto.Select(dto => new Student
                {
                    //Id = dto.Id,
                    FirstName = dto.FirstName,
                    MiddleName = dto.MiddleName,
                    LastName = dto.LastName,
                    BirthDate = DateOnly.FromDateTime(dto.BirthDate), // Convert DateTime to DateOnly
                    Address = dto.Address,
                    AdvisorId = dto.AdvisorId,
                    DeptId = dto.DeptId,
                    Level = dto.Level,
                    HighSchoolGrade = dto.HighSchoolGrade,
                    Gender = dto.Gender,
                    MobilePhone = dto.MobilePhone,
                    HomePhone = dto.HomePhone,
                    SSN = dto.SSN,
                    RegisterYear = dto.RegisterYear
                    
                }).ToList();

                context.ChangeTracker.Clear();
                context.Students.AddRange(students);
                context.SaveChanges();
            }
        }
        public static void SeedReceipts(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "receipts.json");
            if (!context.Receipts.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Receipt>>(jsonData);

                if (rooms != null)
                {
                    context.Receipts.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedApplications(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "application.json");
            if (!context.Applications.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Models.Application>>(jsonData);

                if (rooms != null)
                {
                    context.Applications.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedEnrollments(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "enrollment.json");
            if (!context.Enrollments.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<Enrollment>>(jsonData);

                if (rooms != null)
                {
                    context.Enrollments.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedInstructorAssistants(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "inst-assis.json");
            if (context.FacultyMembers.Count()<24) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<FacultyMember>>(jsonData);
                    context.FacultyMembers.AddRange(rooms);
                    context.SaveChanges();
            }
        }
        public static void SeedInstructorSchedules(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "instructorschedule.json");
            if (!context.InstructorSchedules.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<InstructorSchedule>>(jsonData);

                if (rooms != null)
                {
                    context.InstructorSchedules.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedStudentSchedules(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "studentschedule.json");
            if (!context.StudentSchedules.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<StudentSchedule>>(jsonData);

                if (rooms != null)
                {
                    context.StudentSchedules.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static void SeedFollowUpSchedules(AppDbContext context, IHostEnvironment env)
        {
            var filePath = Path.Combine(env.ContentRootPath, "wwwroot", "json", "followupschedule.json");
            if (!context.FollowUpSchedules.Any()) // Prevent duplicate seeding
            {
                var jsonData = File.ReadAllText(filePath);
                var rooms = JsonSerializer.Deserialize<List<FollowUpSchedule>>(jsonData);

                if (rooms != null)
                {
                    context.FollowUpSchedules.AddRange(rooms);
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roles = { "User",
                "Advisor",
                "Admin",
                "Student",
                "FinancialAffairs",
                "ManagerOfFinancialAffairs",
                "StudentAffairs",
                "ManagerOfStudentAffairs",
                "Instructor",
                "Assistant",
                "Head",
                "Dean",
                "FollowUp" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
        public static async Task SeedUsers(IServiceProvider serviceProvider)
        {
            var _userManager = serviceProvider.GetRequiredService<UserManager<GPUser>>();

            var usersWithRoles = new Dictionary<string, string>
    {
        { "adm@g.com", "Admin" },
        { "adv@g.com", "Advisor" },
        { "std@g.com", "Student" },
        { "finan@g.com", "FinancialAffairs" }, // Fixed Typo
        { "mfinan@g.com", "ManagerOfFinancialAffairs" }, // Fixed Typo
        { "mstdaff@g.com", "ManagerOfStudentAffairs" }, // Fixed Typo
        { "stdaff@g.com", "StudentAffairs" },
        { "inst@g.com", "Instructor" },
        { "assis@g.com", "Assistant" },
        { "head@g.com", "Head" },
        { "dean@g.com", "Dean" },
        { "follow@g.com", "FollowUp" }
    };

            foreach (var userWithRole in usersWithRoles)
            {
                string email = userWithRole.Key;
                string role = userWithRole.Value;

                var user = await _userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    user = new GPUser { UserName = email, Email = email, EmailConfirmed = true };
                    var result = await _userManager.CreateAsync(user, "qweQWE123!!");

                    if (!result.Succeeded)
                    {
                        Console.WriteLine($"Failed to create user {email}");
                        foreach (var error in result.Errors)
                        {
                            Console.WriteLine($"Error: {error.Description}");
                        }
                        continue; // Skip to the next user if creation fails
                    }
                }

                // Ensure the role exists before assigning
                var _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    Console.WriteLine($"Role '{role}' does not exist. Skipping user {email}.");
                    continue; // Skip role assignment if role does not exist
                }
                // Assign role if user isn't already in it
                if (!await _userManager.IsInRoleAsync(user, role))
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, role);

                    if (!roleResult.Succeeded)
                    {
                        Console.WriteLine($"Failed to assign role {role} to {email}");
                        foreach (var error in roleResult.Errors)
                        {
                            Console.WriteLine($"Error: {error.Description}");
                        }
                    }
                }
            }
        }

    }
}
