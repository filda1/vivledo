using System;
using vivledo.mobile.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vivledo.mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new View.HomePage();
            MainPage = new ShellPage();
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
