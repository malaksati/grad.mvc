﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class FacultyMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int WorkingHours { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public ICollection<Schedule> InstructorSchedules { get; set; }
        public ICollection<Schedule> AssistantSchedules { get; set; }

    }
}
