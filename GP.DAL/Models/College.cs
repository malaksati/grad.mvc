using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class College
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("FacultyMember")]
        public int Dean { get; set; }
        public virtual FacultyMember? FacultyMember { get; set; }
    }
}
