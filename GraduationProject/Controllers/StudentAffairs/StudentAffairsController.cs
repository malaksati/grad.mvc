using Microsoft.AspNetCore.Mvc;
using GP.DAL.Models;
namespace GraduationProject.Controllers.StudentAffairs
{
    public class StudentAffairsController : Controller
    {
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
