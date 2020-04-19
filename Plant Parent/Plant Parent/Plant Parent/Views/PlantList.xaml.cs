using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plant_Parent.ViewModel;
using Plant_Parent.Model;

namespace Plant_Parent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlantList : ContentPage
	{
		public PlantList ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddPlant());
        }

        protected override void OnAppearing()
        {
            PlantW.ItemsSource = PlantViewModel.getMyPlants();
            PlantW.SelectedItem = null;
        }

        private void PlantW_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushModalAsync(new EditDeletePlantViewPage());
            }
        }
    }
}