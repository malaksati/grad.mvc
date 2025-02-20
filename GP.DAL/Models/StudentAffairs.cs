using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class StudentAffairs : Employee
    {
        [ForeignKey("Employee")]
        public int ManagerId { get; set; }
        public Employee? Employee { get; set; }
    }
}
