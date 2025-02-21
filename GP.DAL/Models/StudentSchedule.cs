using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class StudentSchedule : Schedule
    {
        public int Group {  get; set; }
        public int Level { get; set; }
        public virtual int DeptId { get; set; }
        public Department Department { get; set; }
    }
}
