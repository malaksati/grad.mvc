using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Advisor : Employee
    {
        public ICollection<Student> Students { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
