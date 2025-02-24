using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult ShowRequests()
        {
            return View();
        }
    }
}
