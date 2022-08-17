using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvmEstructura.Vistas;

namespace MvmEstructura
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new Pagina1();
            MainPage = new NavigationPage(new Pagina1());


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
