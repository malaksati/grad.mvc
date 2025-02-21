using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.DAL.Models;
using GP.DAL.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GP.DAL.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            // College and dean (facultymembers) 1-1
            modelBuilder.Entity<College>()
                .HasOne(d => d.Dean)
                .WithOne()
                .HasForeignKey<College>(d => d.DeanId)
                .OnDelete(DeleteBehavior.Restrict);
            //college and department 1-m
            modelBuilder.Entity<College>()
                .HasMany(c => c.Departments)
                .WithOne(c => c.College)
                .HasForeignKey(c => c.CollegeId)
                .OnDelete(DeleteBehavior.Restrict);
            //college and receipts 1-m
            modelBuilder.Entity<College>()
                .HasMany(c => c.Receipts)
                .WithOne(c => c.College)
                .HasForeignKey(c => c.CollegeId)
                .OnDelete(DeleteBehavior.Restrict);
            // department and head (facultymember) 1-1
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Head)
                .WithOne()
                .HasForeignKey<Department>(d => d.HeadId)
                .OnDelete(DeleteBehavior.Restrict);
            // department and facultymember 1-m
            modelBuilder.Entity<Department>()
                .HasMany(d => d.FacultyMembers)
                .WithOne(fm => fm.Department)
                .HasForeignKey(fm => fm.DeptId)
                .OnDelete(DeleteBehavior.Restrict);
            // department and StudentSchedule 1-m
            modelBuilder.Entity<Department>()
                .HasMany(d => d.StudentSchedules)
                .WithOne(fm => fm.Department)
                .HasForeignKey(fm => fm.DeptId)
                .OnDelete(DeleteBehavior.Restrict);
            // department and course 1-m
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DeptId)
                .OnDelete(DeleteBehavior.Restrict);
            // students and department 1-m
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Students)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DeptId)
                .OnDelete(DeleteBehavior.Restrict);
            // followup and followupschedules 1-m
            modelBuilder.Entity<FollowUp>()
                .HasMany(f=>f.FollowUpSchedules)
                .WithOne(c => c.FollowUp)
                .HasForeignKey(c => c.FollowUpId)
                .OnDelete(DeleteBehavior.Restrict);
            // student affairs and receipts 1-m
            modelBuilder.Entity<StudentAffairs>()
                .HasMany(c => c.Receipts)
                .WithOne(c => c.StudentAffairs)
                .HasForeignKey(c => c.StudentAffairsId)
                .OnDelete(DeleteBehavior.Restrict);
            // manager and student affairs 1-1
            modelBuilder.Entity<StudentAffairs>()
                .HasOne(sa => sa.Manager)
                .WithMany(sa => sa.Subordinates)
                .HasForeignKey(sa => sa.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
            // financial affairs and receipts 1-m
            modelBuilder.Entity<FinancialAffairs>()
                .HasMany(c => c.Receipts)
                .WithOne(c => c.FinancialAffairs)
                .HasForeignKey(c => c.FinancialAffairsId)
                .OnDelete(DeleteBehavior.Restrict);
            // manager and financial affairs 1-1
            modelBuilder.Entity<FinancialAffairs>()
                .HasOne(sa => sa.Manager)
                .WithMany(sa => sa.Subordinates)
                .HasForeignKey(sa => sa.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
            // One-to-Many relationship between Course and Schedule
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Schedules)
                .HasForeignKey(s => s.CourseCode)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-Many relationship between Instructor and Schedule
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Instructor)
                .WithMany(fm => fm.InstructorSchedules)
                .HasForeignKey(s => s.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-Many relationship between Assistant and Schedule
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Assistant)
                .WithMany(fm => fm.AssistantSchedules)
                .HasForeignKey(s => s.AssistantId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-Many relationship between Place and Schedule
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Place)
                .WithMany(p => p.Schedules)
                .HasForeignKey(s => s.PlaceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Enrollment>()
                    .HasKey(e => new { e.StudentId, e.CourseCode });

            // Configure relationship between Student and Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure relationship between Course and Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseCode)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure relationship between Application and StudentAffairs
            modelBuilder.Entity<Application>()
                .HasOne(e => e.StudentAffairs)
                .WithMany(c => c.Applications)
                .HasForeignKey(e => e.StudentAffairsId)
                .OnDelete(DeleteBehavior.Restrict);

            // advisor and student 1-m
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Advisor)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.AdvisorId)
                .OnDelete(DeleteBehavior.Restrict);

            // advisor to schedules 1-m
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Advisor)
                .WithMany(a => a.Schedules)
                .HasForeignKey(s => s.AdvisorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure inheritance
            modelBuilder.Entity<FollowUpSchedule>().HasBaseType<Schedule>();
            modelBuilder.Entity<StudentSchedule>().HasBaseType<Schedule>();
            modelBuilder.Entity<FinancialAffairs>().HasBaseType<Employee>();
            modelBuilder.Entity<StudentAffairs>().HasBaseType<Employee>();
            modelBuilder.Entity<FollowUp>().HasBaseType<Employee>();
            modelBuilder.Entity<Advisor>().HasBaseType<Employee>();

            // Table-Per-Type (TPT)
            modelBuilder.Entity<Advisor>().ToTable("Advisors");
            modelBuilder.Entity<FinancialAffairs>().ToTable("FinancialAffairs");
            modelBuilder.Entity<FollowUp>().ToTable("FollowUps");
            modelBuilder.Entity<FollowUpSchedule>().ToTable("FollowUpSchedules");
            modelBuilder.Entity<StudentAffairs>().ToTable("StudentAffairs");
            modelBuilder.Entity<StudentSchedule>().ToTable("StudentSchedule");

            var dateConverter = new ValueConverter<DateOnly, DateTime>(
                v => v.ToDateTime(TimeOnly.MinValue), // Convert DateOnly -> DateTime
                v => DateOnly.FromDateTime(v));       // Convert DateTime -> DateOnly

            modelBuilder.Entity<Student>()
                .Property(e => e.BirthDate)
                .HasConversion(dateConverter)
                .HasColumnType("date");

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.SSN)
                .IsUnique();
            modelBuilder.Entity<Student>()
                .HasIndex(e => e.SSN)
                .IsUnique();
            modelBuilder.Entity<FacultyMember>()
                .HasIndex(e => e.SSN)
                .IsUnique();

            modelBuilder.Entity<CoursePrerequisite>()
                .HasKey(cp => new { cp.CourseCode, cp.PrerequisiteCode });

            modelBuilder.Entity<CoursePrerequisite>()
                .HasOne(cp => cp.Course)
                .WithMany(c => c.Prerequisites)
                .HasForeignKey(cp => cp.CourseCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoursePrerequisite>()
                .HasOne(cp => cp.Prerequisite)
                .WithMany(c => c.RequiredFor)
                .HasForeignKey(cp => cp.PrerequisiteCode)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            // Seed

            modelBuilder.Entity<Place>().HasData(PlaceSeeder.GetPreconfiguredPlaces());

            modelBuilder.Entity<Advisor>().HasData(AdvisorSeeder.GenerateEmployees());

            modelBuilder.Entity<FollowUp>().HasData(FollowUpSeeder.GenerateEmployees());

            modelBuilder.Entity<StudentAffairs>().HasData(StudentAndFinancialAffairsSeeder.GenerateStudentAffairs());

            modelBuilder.Entity<FinancialAffairs>().HasData(StudentAndFinancialAffairsSeeder.GenerateFinancialAffairs());
            
            modelBuilder.Entity<College>().HasData(CollegeDepartmentFacultyMemberSeeder.GenerateColleges());

            modelBuilder.Entity<Department>().HasData(CollegeDepartmentFacultyMemberSeeder.GenerateDepartments());

            modelBuilder.Entity<FacultyMember>().HasData(CollegeDepartmentFacultyMemberSeeder.GenerateFacultyMembers());
            
            modelBuilder.Entity<Course>().HasData(CourseSeeder.GenerateCourses());
            
            modelBuilder.Entity<CoursePrerequisite>().HasData(CourseSeeder.GeneratePrerequisites());
            


        }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<FinancialAffairs> FinancialAffairs { get; set; }
        public DbSet<FollowUp> FollowUps { get; set; }
        public DbSet<FollowUpSchedule> FollowUpSchedules { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAffairs> StudentAffairs { get; set; }
        public DbSet<StudentSchedule> StudentSchedules { get; set; }


    }
}
