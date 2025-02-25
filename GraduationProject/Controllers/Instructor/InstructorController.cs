using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Instructor
{
    public class InstructorController : Controller
    {
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
