using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public static class FollowUpSeeder
    {
        public static List<FollowUp> GenerateEmployees()
        {
            return new List<FollowUp>
        {
            new()
            {
                Id = 3,
                SSN = "1122334455667788", // Exactly 16 digits
                FirstName = "Omar",
                MiddleName = "Ibrahim",
                LastName = "Hassan",
                Salary = 4800.00,
                MobilePhone = "01098765432", // Exactly 11 digits
                Address = "Giza, Dokki",
                Gender = Gender.Male
            },
            new()
            {
                Id = 4,
                SSN = "2233445566778899",
                FirstName = "Sara",
                MiddleName = "Mostafa",
                LastName = "Adel",
                Salary = 5200.75,
                MobilePhone = "01211223344",
                Address = "Alexandria, Sidi Gaber",
                Gender = Gender.Female
            },
            new()
            {
                Id = 5,
                SSN = "3344556677889900",
                FirstName = "Hassan",
                MiddleName = "Amr",
                LastName = "Kamal",
                Salary = 4900.25,
                MobilePhone = "01555667788",
                Address = "Mansoura, Talkha",
                Gender = Gender.Male
            }
        };
        }
    }

}
