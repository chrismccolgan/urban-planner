using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Established { get; set; }
        public List<Building> allBuildings { get; set; }
        public void AddBuilding(Building aBuilding)
        {
            allBuildings.Add(aBuilding);
        }
        public void AddMayor(string aMayor)
        {
            Mayor = aMayor;
        }
        public City(string cityName)
        {
            Name = cityName;
            Established = 1900;
            allBuildings = new List<Building>();
        }
        public void ListBuildings()
        {
            Console.WriteLine($"City of {Name}");
            Console.WriteLine("---------------");
            Console.WriteLine($"Established: {Established}");
            Console.WriteLine($"Mayor: {Mayor}");
            Console.WriteLine();
            foreach (Building building in allBuildings)
            {
                building.Message();
            }
        }
    }
}