using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Models
{
    public class FinancialAffairs : Employee
    {
        public int? ManagerId { get; set; }
        public FinancialAffairs Manager { get; set; }
        public ICollection<FinancialAffairs> Subordinates { get; set; }
        public ICollection<Receipt> Receipts { get; set; }

    }
}
