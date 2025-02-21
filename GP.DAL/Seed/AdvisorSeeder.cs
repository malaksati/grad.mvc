using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public static class AdvisorSeeder
    {
        public static List<Advisor> GenerateEmployees()
        {
            return new List<Advisor>{
            new() {
                Id = 1,
                SSN = "1234567890123456", // Exactly 16 digits
                FirstName = "Mohamed",
                MiddleName = "Ahmed",
                LastName = "Mostafa",
                Salary = 5000.00,
                MobilePhone = "01234567890", // Exactly 11 digits
                Address = "Cairo, Maadi",
                Gender = Gender.Male
            },
            new() {
                Id = 2,
                SSN = "9876543210987654",
                FirstName = "Jana",
                MiddleName = "Mohamed",
                LastName = "Ali",
                Salary = 5500.50,
                MobilePhone = "01123456789",
                Address = "Cairo, Mokattam",
                Gender = Gender.Female
            }
        };
        }
    }
}
