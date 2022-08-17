using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App.Cambista.Vistas;


namespace App.Cambista
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new Principal());

            //MainPage = new Convertir();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
