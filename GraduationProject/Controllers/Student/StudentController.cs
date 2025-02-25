using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Student
{
    public class StudentController : Controller
    {
        public IActionResult StudentSchedule()
        {
            return View();
        }
    }
}
