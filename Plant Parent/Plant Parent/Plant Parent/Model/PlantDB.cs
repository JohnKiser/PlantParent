using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.Linq;

namespace Plant_Parent.Model
{  
    public class PlantDB
    {
        private SQLiteConnection _connect;

        public PlantDB()
        {
            try
            {
                _connect = DependencyService.Get<ISQLite>().GetConnection();
                _connect.CreateTable<Plant>();
            }
            catch(NullReferenceException e)
            {
                Console.Write(e);
            }
            
        }

        public IList<Plant> GetPlants()
        {
            return _connect.Query<Plant>("SELECT * FROM PlantTable ORDER BY Room");
        }

        public Plant GetPlant(int id)
        {
            return _connect.Table<Plant>().FirstOrDefault(t => t.ID == id);
        }

        public void DetelePlant(int id)
        {
            _connect.Delete<Plant>(id);
        }

        public void AddPlant(Plant p)
        {
            var newPlant = new Plant
            {
                PlantType = p.PlantType,
                Container = p.Container,
                Room = p.Room,
                Water = p.Water
            };
            _connect.Insert(newPlant);
        }

        public void UpdatePlant(int id, Plant p)
        {
            _connect.Execute("UPDATE PlantTable SET PlantType = ?, Container = ?, Room = ?, Water = ? WHERE ID =?", p.PlantType, p.Container, p.Room, p.Water, id);
        }

        public int Count()
        {
            return _connect.Table<Plant>().Count();
        }
    }
}
