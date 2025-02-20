using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GP.DAL.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>().HasKey(E =>new
            {
                E.StudentId,
                E.CourseCode
            });
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());


        }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<FinancialAffairs> FinancialAffairs { get; set; }
        public DbSet<FollowUpSchedule> FollowUpSchedules { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorSchedule> InstructorSchedules { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAffairs> StudentAffairs { get; set; }
        public DbSet<StudentSchedule> StudentSchedules { get; set; }


    }
}
