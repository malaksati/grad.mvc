using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace GraduationProject.Controllers.FollowUp
{
    [Authorize("FollowUp")]
    public class FollowUpController : Controller
    {
        public IActionResult FollowUpSchedule()
        {
            return View();
        }
    }
}
