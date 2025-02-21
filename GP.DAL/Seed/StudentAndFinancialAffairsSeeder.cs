using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public static class StudentAndFinancialAffairsSeeder
    {
        public static List<StudentAffairs> GenerateStudentAffairs()
        {
            return new List<StudentAffairs>
        {
            new()
            {
                Id = 6,
                SSN = "4455667788990011",
                FirstName = "Ali",
                MiddleName = "Youssef",
                LastName = "Mahmoud",
                Salary = 4700.00,
                MobilePhone = "01022334455",
                Address = "Cairo, Nasr City",
                Gender = Gender.Male,
                ManagerId = null // Adjust if needed
            },
            new()
            {
                Id = 7,
                SSN = "5566778899081122",
                FirstName = "Laila",
                MiddleName = "Karim",
                LastName = "Nabil",
                Salary = 4800.50,
                MobilePhone = "01155667788",
                Address = "Alexandria, Smouha",
                Gender = Gender.Female,
                ManagerId = 6 // Assuming Ali is the manager
            },
            new()
            {
                Id = 8,
                SSN = "5562778899001122",
                FirstName = "Dana",
                MiddleName = "Karim",
                LastName = "Mohamed",
                Salary = 4800.50,
                MobilePhone = "01155667788",
                Address = "Alexandria, Smouha",
                Gender = Gender.Female,
                ManagerId = 6 // Assuming Ali is the manager
            }
        };
        }

        public static List<FinancialAffairs> GenerateFinancialAffairs()
        {
            return new List<FinancialAffairs>
        {
            new()
            {
                Id = 9,
                SSN = "6677889900112233",
                FirstName = "Mona",
                MiddleName = "Hassan",
                LastName = "Ibrahim",
                Salary = 5300.75,
                MobilePhone = "01266778899",
                Address = "Giza, Haram",
                Gender = Gender.Female,
                ManagerId = null // Adjust if needed
            },
            new()
            {
                Id = 10,
                SSN = "7788690011203344",
                FirstName = "Omar",
                MiddleName = "Nour",
                LastName = "Saad",
                Salary = 5500.00,
                MobilePhone = "01577889900",
                Address = "Mansoura, Aga",
                Gender = Gender.Male,
                ManagerId = 9 // Assuming Mona is the manager
            },
            new()
            {
                Id = 11,
                SSN = "7783990011228344",
                FirstName = "Hamed",
                MiddleName = "Mohamed",
                LastName = "Saad",
                Salary = 5500.00,
                MobilePhone = "01577889900",
                Address = "Mansoura, Aga",
                Gender = Gender.Male,
                ManagerId = 9 // Assuming Mona is the manager
            }
        };
        }
    }

}
