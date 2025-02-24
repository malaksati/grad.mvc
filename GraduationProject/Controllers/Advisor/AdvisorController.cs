using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Advisor
{
    public class AdvisorController : Controller
    {
        public IActionResult SemesterInfoPage()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult InstructorInfoPage()
        {
            return View();
        }
        public IActionResult DefaultSchedule()
        {
            return View();
        }
    }
}
