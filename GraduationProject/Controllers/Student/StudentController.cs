using GP.BLL.Interfaces;
using GP.BLL.Repositories;
using GP.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.Student
{
    //[Authorize(Roles = "Student")]

    public class StudentController : Controller
    {
        private readonly IStudentScheduleRepository _studentScheduleRepository;
        public StudentController(IStudentScheduleRepository studentScheduleRepository)
        {
            _studentScheduleRepository = studentScheduleRepository;
        }

        public IActionResult StudentSchedule()
        {
            ViewData["Schedule"] = _studentScheduleRepository.GetStudentScheduleByScheduleId(2);

            return View();
        }
    }
}
