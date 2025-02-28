using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GP.DAL.Models
{
    public class GPUser :IdentityUser
    {

        public string? FName { get; set; }
        public string? LName { get; set; }
      
    }
}
