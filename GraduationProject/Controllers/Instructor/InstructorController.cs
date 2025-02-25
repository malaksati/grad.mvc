using GP.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Instructor
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _context;

        public InstructorController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult InstructorSchedule()
        {
            return View();
        }
        public IActionResult AssistantSchedule()
        {
            return View();
        }
    }
}
