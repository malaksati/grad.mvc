using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class InstructorSchedule
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Day { get; set; }
        public DateTime Time { get; set; }
        public string Semester { get; set; }
        public int AcademicYear { get; set; }
        [ForeignKey("Place")]
        public int PlaceId { get; set; }
        [ForeignKey("Instructor")]
        public string InstructorId { get; set; }
        [ForeignKey("Assistant")]
        public string AssistantId { get; set; }
        [ForeignKey("Course")]
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public Place? Place { get; set; }
        public Course? Course { get; set; }
        public Instructor Instructor { get; set; }
        public Assistant Assistant { get; set; }
    }
    public enum Type { Instructor, Assistant }
}
