using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string CourseCode { get; set; }
        public Course Course { get; set; }
        public string Grade { get; set; }
        public int AcademicYear { get; set; }
        public int Level { get; set; }
        public SemesterType Semester { get; set; }
    }
}
