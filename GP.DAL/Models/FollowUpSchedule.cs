using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class FollowUpSchedule: StudentSchedule
    {
        public int Week {  get; set; }
        public bool IsAttendant { get; set; }
    }
}
