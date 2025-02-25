using GP.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult Dashboard()
        {
            ViewData["Courses"] = _context.Courses.ToList();
            ViewData["Departments"] = _context.Departments.ToList();
            return View();
        }
        public IActionResult CourseAddPage()
        {
            return View();
        }
        public IActionResult DepartmentAddPage()
        {
            return View();
        }
        public IActionResult CourseEditPage()
        {
            return View();
        }
        public IActionResult DepartmentEditPage()
        {
            return View();
        }
        public IActionResult ShowRequests()
        {
            return View();
        }
    }
}
