using System;
using System.ComponentModel;
using vivledo.device.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vivledo.device.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }


        async void OnClickButtonOne(object sender, EventArgs e)
        {
            var blnResponse = await App.Current.MainPage.DisplayAlert("Título", "Coloque uma mensagem aqui..", "Ok", "Cancelar");

            string strMessage = (blnResponse ? "Apertou Ok!" : "Apertou Cancelar");
            await App.Current.MainPage.DisplayAlert("Título", strMessage, "Ok");
        }

        async void OnClickButtonTwo(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Título", "Alert de confirmação", "Ok");
        }

        async void OnClickButtonThree(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Título", "Pesquisa", "Ok");
        }
    }
}
