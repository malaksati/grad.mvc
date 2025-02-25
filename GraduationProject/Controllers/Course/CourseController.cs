using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Course
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult Add()
        {
            return RedirectToAction("");
        }
        public IActionResult Edit()
        {
            return RedirectToAction("");
        }
    }
}
