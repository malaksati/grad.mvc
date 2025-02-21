using GP.DAL.Context;
using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public static class CollegeDepartmentFacultyMemberSeeder
    {
        public static List<College> GenerateColleges()
        {
            return new List<College>
        {
            new()
            {
                Id = 1,
                Name = "Engineering",
                DeanId = 1 // Assigning the first FacultyMember as the Dean
            },
            new()
            {
                Id = 2,
                Name = "Computers and Artificial Intelligence",
                DeanId = 2
            },
            new()
            {
                Id = 3,
                Name = "Pharmacy",
                DeanId = 3
            }
        };
        }
        public static List<FacultyMember> GenerateFacultyMembers()
        {
            return new List<FacultyMember>
        {
            new()
            {
                Id = 1,
                SSN = "1111322233334444",
                FirstName = "Reham", // Reham Ibrahem Momtaz
                MiddleName = "Ibrahem",
                LastName = "Momtaz",
                MobilePhone = "01012345678",
                Address = "Cairo, Nasr City",
                WorkingHours = 3,
                //DeptId = null // Dean of Engineering
            },
            new()
            {
                Id = 2,
                SSN = "5555666677578888",
                FirstName = "Mohamed", //Mohamed El Mayah
                MiddleName = "El",
                LastName = "Mayah",
                MobilePhone = "01198765432",
                Address = "Giza, Dokki",
                WorkingHours = 3,
                //DeptId = null // Dean of Computer Science
            },
            new()
            {
                Id = 3,
                SSN = "9919000011112222",
                FirstName = "Shohda", //Shohda El Maraghy
                MiddleName = "El",
                LastName = "Maraghy",
                MobilePhone = "01234567890",
                Address = "Alexandria, Smouha",
                WorkingHours = 3,
                //DeptId = null // Dean of Pharmacy
            },
            new()
            {
                Id = 4,
                SSN = "2222333344345555",
                FirstName = "Hanafy",
                MiddleName = "Mahmoud",
                LastName = "Ismail",
                MobilePhone = "01556789012",
                Address = "Mansoura, Aga",
                WorkingHours = 6,
                //DeptId = 1 // Head of Computer Science
            },
            new()
            {
                Id = 5,
                SSN = "6666770788889999",
                FirstName = "Hafez",
                MiddleName = "Abd",
                LastName = "ElWahab",
                MobilePhone = "01087654321",
                Address = "Fayoum, Senouras",
                WorkingHours = 6,
                //DeptId = 3 // Head of Information Systems
            },
            new()
            {
                Id = 6,
                SSN = "6666777788869999",
                FirstName = "Hesham",
                MiddleName = "Mohamed",
                LastName = "El-Deeb",
                MobilePhone = "01087654321",
                Address = "Fayoum, Senouras",
                WorkingHours = 6,
                //DeptId = 2 // Head of Artificial Intillegence
            },
            new()
            {
                Id = 7,
                SSN = "6666737788869999",
                FirstName = "Elsayed",
                MiddleName = "Abdel Aziz",
                LastName = "Soleit",
                MobilePhone = "01087654321",
                Address = "Fayoum, Senouras",
                WorkingHours = 6,
                //DeptId = 4 // Head of Electrical Engineering
            },
            new()
            {
                Id = 8,
                SSN = "2222373344345555",
                FirstName = "Mohammed",
                MiddleName = "Mahmoud",
                LastName = "El Fawal",
                MobilePhone = "01556789012",
                Address = "Mansoura, Aga",
                WorkingHours = 6,
                //DeptId = 5 // Head of Mechnical Engineering
            },
            new()
            {
                Id = 9,
                SSN = "2222373344343555",
                FirstName = "Mona",
                MiddleName = "Samir",
                LastName = "Mehanna",
                MobilePhone = "01556789012",
                Address = "Mansoura, Aga",
                WorkingHours = 6,
                //DeptId = 6 // Head of Physics and Mathematical Engineering
            }
            ,
            new()
            {
                Id = 10,
                SSN = "2272373344034355",
                FirstName = "Eman",
                MiddleName = "Mokhtar",
                LastName = "Omar",
                MobilePhone = "01556789012",
                Address = "Mansoura, Aga",
                WorkingHours = 6,
                //DeptId = 7 // Head of Architectural Engineering
            },
            new()
            {
                Id = 11,
                SSN = "2272303544034355",
                FirstName = "Dalia",
                MiddleName = "Adel",
                LastName = "Mohamed",
                MobilePhone = "01556289012",
                Address = "Mansoura, Aga",
                WorkingHours = 6,
                //DeptId = 8 // Head of Pharmacognosy
            },
            new()
            {
                Id = 12,
                SSN = "1101322233334444",
                FirstName = "Tamer", 
                MiddleName = "Mohamed",
                LastName = "Nasr",
                MobilePhone = "01012345678",
                Address = "Cairo, Nasr City",
                WorkingHours = 6,
                //DeptId = 9 // Head of Pharmaceutical Chemistry
            },
            new()
            {
                Id = 13,
                SSN = "1101322233333444",
                FirstName = "Nesreen",
                MiddleName = "Nabil",
                LastName = "Omar",
                MobilePhone = "01012345678",
                Address = "Cairo, Nasr City",
                WorkingHours = 6,
                //DeptId = 9 // Head of Biochemistry
            }
        };
        }
        
        public static List<Department> GenerateDepartments()
        {
            return new List<Department>
        {
            new()
            {
                Id = 1,
                Name = "Computer Science",
                CollegeId = 2,
                HeadId = 4
            },
            new()
            {
                Id = 2,
                Name = "Artificial Intelligence",
                CollegeId = 2,
                HeadId = 6
            },
            new()
            {
                Id = 3,
                Name = "Information Systems",
                CollegeId = 2,
                HeadId = 5
            },
            new()
            {
                Id = 4,
                Name = "Electrical Engineering",
                CollegeId = 1,
                HeadId = 7
            },
            new()
            {
                Id = 5,
                Name = "Mechnical Engineering",
                CollegeId = 1,
                HeadId = 8
            },
            new()
            {
                Id = 6,
                Name = "Physics and Mathematical Engineering",
                CollegeId = 1,
                HeadId = 9
            },
            new()
            {
                Id = 7,
                Name = "Architectural Engineering",
                CollegeId = 1,
                HeadId = 10
            },
            new()
            {
                Id = 8,
                Name = "Pharmacognosy",
                CollegeId = 3,
                HeadId = 11
            },
            new()
            {
                Id = 9,
                Name = "Pharmaceutical Chemistry",
                CollegeId = 3,
                HeadId = 12
            }
            ,
            new()
            {
                Id = 10,
                Name = "Biochemistry",
                CollegeId = 3,
                HeadId = 13
            }
        };
        }
    }
}
