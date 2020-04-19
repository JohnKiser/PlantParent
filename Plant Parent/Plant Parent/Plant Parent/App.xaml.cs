using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plant_Parent.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Plant_Parent
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PlantList();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
