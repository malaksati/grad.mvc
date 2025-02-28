using GP.BLL.Interfaces;
using GP.BLL.Repositories;
using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Instructor
{
    public class InstructorController : Controller
    {
     //   private readonly AppDbContext _context;
        private readonly IInstructorScheduleRepositroy _instructorScheduleRepositroy;

        public InstructorController(IInstructorScheduleRepositroy instructorScheduleRepositroy)
        {
            //_context = context; // Dependency Injection
            _instructorScheduleRepositroy = instructorScheduleRepositroy;
        }
        [Authorize(Roles = "Instructor")]
        public IActionResult InstructorSchedule()
        {
            var schedule = _instructorScheduleRepositroy.GetInstructorSchedule();
            Console.WriteLine(schedule);
            return View(schedule);
        }
        [Authorize(Roles = "Assistant")]

        public IActionResult AssistantSchedule()
        {
            return View();
        }
    }
}
