using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using vivledo.device.Services;
using vivledo.device.Views;

namespace vivledo.device
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            //this.MainPage = new NavigationPage(new LoginPage());
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
