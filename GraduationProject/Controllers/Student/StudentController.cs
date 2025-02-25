using GP.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Student
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult StudentSchedule()
        {
            return View();
        }
    }
}
