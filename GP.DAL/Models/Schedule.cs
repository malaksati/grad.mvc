using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Semester { get; set; }
        public int AcademicYear { get; set; }
        public int PlaceId { get; set; }
        public int InstructorId { get; set; }
        public int AssistantId { get; set; }
        public string CourseCode { get; set; }
        public int AdvisorId { get; set; }
        public Advisor Advisor { get; set; }
        public Place Place { get; set; }
        public Course Course { get; set; }
        public FacultyMember Instructor { get; set; }
        public FacultyMember Assistant { get; set; }
    }
}
