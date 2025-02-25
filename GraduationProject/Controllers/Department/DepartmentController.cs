using GP.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Department
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
