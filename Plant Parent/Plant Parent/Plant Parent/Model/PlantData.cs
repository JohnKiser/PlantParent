using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Plant_Parent.Model
{
    public static class PlantData
    {
        public static IList<Plant> Plants { get; private set; }

        public static void AddPush(Plant p)
        {
            Plants.Add(p);
            Plants = Plants.OrderBy(plant => plant.Room).ToList();
        }

        static PlantData()
        {
            Plants = new List<Plant>();

            Plants.Add(new Plant
            {
                PlantType = "Fern",
                Container = "Blue pot",
                Room = "Livingroom",
                Water = 5
            });

            Plants.Add(new Plant
            {
                PlantType = "Daisy",
                Container = "Yellow pot",
                Room = "Bathroom",
                Water = 3
            });

            Plants = Plants.OrderBy(plant => plant.Room).ToList();
        }

        public static void ResortRoom()
        {
            Plants = Plants.OrderBy(plant => plant.Room).ToList();
        }
    }
}
