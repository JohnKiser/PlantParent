using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Plant_Parent.Model
{
    [Table("PlantTable")]
    public class Plant
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string PlantType { get; set; }

        public string Container { get; set; }

        public string Room { get; set; }

        public int Water { get; set; }

        public string FullDescription { get { return PlantType + " in a " + Container + " watered every " + Water + " days."; } }

        public Plant()
        {

        }

        public Plant(string plantType, string container, string room, int water)
        {
            PlantType = plantType;
            Container = container;
            Room = room;
            Water = water;
        }

    }
}
