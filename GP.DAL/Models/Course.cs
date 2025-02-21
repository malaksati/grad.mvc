using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Course
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public int CreditHour { get; set; }
        public int NoOfSec { get; set; }
        public int NoOfLec { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
