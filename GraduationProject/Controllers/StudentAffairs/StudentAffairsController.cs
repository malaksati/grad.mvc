using Microsoft.AspNetCore.Mvc;
using GP.DAL.Models;
using GP.DAL.Context;
namespace GraduationProject.Controllers.StudentAffairs
{
    public class StudentAffairsController : Controller
    {
        private readonly AppDbContext _context;

        public StudentAffairsController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        [HttpGet]
        public IActionResult NewApplication()
        {
            return View("NewApplication");
        }
        [HttpPost]
        public IActionResult NewApplication(string MobilePhone) // ay 7aga
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
