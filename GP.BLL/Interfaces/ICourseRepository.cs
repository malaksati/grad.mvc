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
        Task<Course> GetCourseById(string id);
        int AddCourse(Course course);
        int UpdateCourse(Course course);
        int DeleteCourse(string courseId);
    }
}
