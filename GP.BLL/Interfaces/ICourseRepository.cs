using GP.DAL.Dto;
using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.BLL.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        IEnumerable<CourseDTO> GetCoursesNameCode();
        Task<Course> GetCourseById(string id);
        int AddCourse(Course course);
        int UpdateCourse(Course course);
        Task<int> DeleteCourseAsync(string Code);
    }
}
