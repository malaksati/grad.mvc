using GP.BLL.Interfaces;
using GP.BLL.Repositories;
using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

namespace GraduationProject.Controllers.Department
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ICollegeRepository _collegeRepository;
        private readonly IFacultyMemberRepsitory _facultyMemberRepsitory;
        public DepartmentController(IDepartmentRepository departmentRepository,
            ICollegeRepository collegeRepository, IFacultyMemberRepsitory facultyMemberRepsitory)
        {
              _departmentRepository = departmentRepository;
            _facultyMemberRepsitory = facultyMemberRepsitory;
            _collegeRepository = collegeRepository;
        }
        public IActionResult Add(GP.DAL.Models.Department dep)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, reload the form with the department data
                ViewData["Colleges"] = _collegeRepository.GetColleges();
                ViewData["Heads"] = _facultyMemberRepsitory.GetHeads();
                return RedirectToAction("DepartmentAddPage", "Admin", dep.Id);
            }

            _departmentRepository.AddDepartment(dep);

            return RedirectToAction("Dashboard", "Admin");
        }
        public IActionResult Delete(int id)
        {
            _departmentRepository.DeleteDepartment(id);
            return RedirectToAction("Dashboard", "Admin");
        }
    }
}
