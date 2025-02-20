﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(16)]
        public int SSN { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }

    }
}
