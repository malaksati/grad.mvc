using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int RegisterYear {  get; set; }
        [Key]
        public int SSN { get; set; }
        public string Address { get; set; }
        [Phone]
        public string MobilePhone { get; set; }
        [Phone]
        public string HomePhone { get; set; }
        public Gender Gender { get; set; }
        public int Level { get; set; }
        public DateTime BirthDate { get; set; }
        public double HighSchoolGrade { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public int AdvisorId { get; set; }
        public Advisor Advisor { get; set; }
    }
    public enum Gender { Male, Female }
}
