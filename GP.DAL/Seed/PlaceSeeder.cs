using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.DAL.Seed
{
    public static class PlaceSeeder
    {
        public static List<Place> GetPreconfiguredPlaces()
        {
            var places = new List<Place>();

            // Sections (Sec1 to Sec12) - Capacity: 40
            for (int i = 1; i <= 12; i++)
            {
                places.Add(new Place
                {
                    Id = i,
                    Name = $"Sec{i}",
                    Type = "Ex",
                    Capacity = "40",
                    IsAvailable = true
                });
            }

            // Labs (Lab1 to Lab6) - Capacity: 28
            for (int i = 1; i <= 6; i++)
            {
                places.Add(new Place
                {
                    Id = 12 + i,
                    Name = $"Lab{i}",
                    Type = "Lab",
                    Capacity = "28",
                    IsAvailable = true
                });
            }

            // Lectures (L1 to L3) - Capacity: 200
            for (int i = 1; i <= 3; i++)
            {
                places.Add(new Place
                {
                    Id = 18 + i,
                    Name = $"L{i}",
                    Type = "L",
                    Capacity = "200",
                    IsAvailable = true
                });
            }

            // Mixed Ex/Lab (72 combinations)
            int mixedExLabId = 22;
            for (int sec = 1; sec <= 12; sec++)
            {
                for (int lab = 1; lab <= 6; lab++)
                {
                    places.Add(new Place
                    {
                        Id = ++mixedExLabId,
                        Name = $"Sec{sec}/Lab{lab}",
                        Type = "Ex/Lab",
                        Capacity = "28", // Lab capacity
                        IsAvailable = true
                    });
                }
            }

            // Mixed Ex/Lab (72 combinations)
            int mixedExLabIdd = 94;
            for (int sec = 1; sec <= 12; sec++)
            {
                for (int lab = 1; lab <= 6; lab++)
                {
                    places.Add(new Place
                    {
                        Id = ++mixedExLabIdd,
                        Name = $"Sec{sec}/Lab{lab}",
                        Type = "Ex/Lab",
                        Capacity = "40", // Sec capacity
                        IsAvailable = true
                    });
                }
            }
            // Mixed L/Ex (36 combinations)
            int mixedLExId = 166;
            for (int lec = 1; lec <= 3; lec++)
            {
                for (int sec = 1; sec <= 12; sec ++) // Ensuring evenly distributed combinations
                {
                    places.Add(new Place
                    {
                        Id = ++mixedLExId,
                        Name = $"L{lec}/Sec{sec}",
                        Type = "L/Ex",
                        Capacity = "40", // Section capacity
                        IsAvailable = true
                    });
                }
            }
            // Mixed L/Ex (36 combinations)
            int mixedLExIdd = 202;
            for (int lec = 1; lec <= 3; lec++)
            {
                for (int sec = 1; sec <= 12; sec ++) // Ensuring evenly distributed combinations
                {
                    places.Add(new Place
                    {
                        Id = ++mixedLExIdd,
                        Name = $"L{lec}/Sec{sec}",
                        Type = "L/Ex",
                        Capacity = "200", // Lecture capacity
                        IsAvailable = true
                    });
                }
            }

            return places;
        }
    }
}
