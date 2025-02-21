using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class FollowUp : Employee
    {
        public ICollection<FollowUpSchedule> FollowUpSchedules { get; set; }
    }
}
