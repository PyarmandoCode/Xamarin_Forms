﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App.Book.Views;


namespace App.Book
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new Views.RoomPage();
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
