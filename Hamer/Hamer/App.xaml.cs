﻿using Hamer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hamer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GreetPage();
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
