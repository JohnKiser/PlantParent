using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plant_Parent.Model;
using Plant_Parent.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plant_Parent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditDeletePlantViewPage : ContentPage
	{
		public EditDeletePlantViewPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            // cancel
            Navigation.PopModalAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            // Delete
            Navigation.PopModalAsync();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            // Save edit
            Navigation.PopModalAsync();
        }
    }
}