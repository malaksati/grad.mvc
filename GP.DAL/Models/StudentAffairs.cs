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
        public int? ManagerId { get; set; }
        public StudentAffairs Manager { get; set; }
        public ICollection<StudentAffairs> Subordinates { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
        public ICollection<Application> Applications { get; set; }

    }
}
