using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Capacity { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
