using System;
using System.Collections.Generic;
using System.Text;
using Plant_Parent.Model;
using Xamarin.Forms;
using SQLite;

namespace Plant_Parent.ViewModel
{
    class PlantViewModel : ViewModelBase
    {
        public static PlantDB plantDB => new PlantDB();

        public Command addPlantCommand { get; private set; }
        public Command savePlantCommand { get; private set; }
        public Command deletePlantCommand { get; private set; }

        public string PlantType { get; set; }
        public string Container { get; set; }
        public string Room { get; set; }
        public int Water { get; set; }

        public PlantViewModel()
        {
            addPlantCommand = new Command(AddPlant);
            savePlantCommand = new Command(SavePlant);
            deletePlantCommand = new Command(DeletePlant);
        }

        private void AddPlant()
        {
            plantDB.AddPlant(new Plant(PlantType, Container, Room, Water));
        }

        private void SavePlant()
        {
            plantDB.UpdatePlant(SelectedPlant.ID, SelectedPlant);
        }

        private void DeletePlant()
        {
            plantDB.DetelePlant(SelectedPlant.ID);
        }

        public static Plant getSelectedPlant()
        {
            return selectedPlant;
        }

        public Plant SelectedPlant
        {
            get
            {
                return selectedPlant;
            }
            set
            {
                if(value != null)
                {
                    savePlant.ID = value.ID;
                    savePlant.PlantType = value.PlantType;
                    savePlant.Container = value.Container;
                    savePlant.Room = value.Room;
                    savePlant.Water = value.Water;
                    selectedPlant = value;
                    OnPropertyChanged();
                }
            }
        }

        private static Plant selectedPlant = null;
        private static Plant savePlant = new Plant();

        public static IList<Plant> getMyPlants()
        {
            return plantDB.GetPlants();
        }
    }
}
