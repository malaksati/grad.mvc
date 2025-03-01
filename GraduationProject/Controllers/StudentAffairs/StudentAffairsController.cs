using Microsoft.AspNetCore.Mvc;
using GP.DAL.Models;
using GP.DAL.Context;
using Microsoft.AspNetCore.Authorization;
namespace GraduationProject.Controllers.StudentAffairs
{
    [Authorize(Roles = "StudentAffairs")]
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
        public IActionResult ApplicationTable()
        {
            return View();
        }
        public IActionResult ApplicationInfo()
        {
            return View();
        }
        public IActionResult ReceiptTable()
        {
            return View();
        }
        public IActionResult ReceiptInfo()
        {
            return View();
        }
        [Authorize("ManagerOfStudentAffairs")]
        public IActionResult ManagerStats()
        {
            return View();
        }
    }
}
