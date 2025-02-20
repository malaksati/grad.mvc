﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class Application
    {
        public int  Id  { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public string Status { get; set; }
        [ForeignKey("StudentAffairs")]
        public int  StudentAffairsId  { get; set; }
        public StudentAffairs StudentAffairs { get; set; }
    }
}
