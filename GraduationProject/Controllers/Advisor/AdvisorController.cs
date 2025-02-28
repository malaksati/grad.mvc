using Microsoft.AspNetCore.Mvc;
using GP.DAL.Context;
using Microsoft.AspNetCore.Authorization;

namespace GraduationProject.Controllers.Advisor
{
    [Authorize(Roles = "Advisor")]

    public class AdvisorController : Controller
    {
        private readonly AppDbContext _context;

        public AdvisorController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult SemesterInfoPage()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            var courses = _context.Courses.ToList();
            var departments = _context.Departments.ToList();
            ViewData["Courses"] = courses;
            ViewData["Departments"] = departments;
            return View();
        }
        public IActionResult InstructorInfoPage()
        {
            return View();
        }
        public IActionResult DefaultSchedule(int List, string Semester, int Level, List<string> Course)
        {
            ViewData["List"] = List;
            ViewData["Semester"] = Semester;
            ViewData["Level"] = Level;
            ViewData["Course"] = Course;
            return View();
        }
        public IActionResult DefaultScheduleEntry() {
            return View("Dashboard");
        }
        [HttpGet]
        public IActionResult RequestCourseModification() {
            return View();
        }
        [HttpPost]
        public IActionResult RequestCourseModification(string Code, string Changes)
        {

            return View();
        }
        [HttpGet]
        public IActionResult RequestDepartmentModification() {

            return View();
        }
        [HttpPost]
        public IActionResult RequestDepartmentModification(int Code, string Changes)
        {
            return View();
        }
    }
}
