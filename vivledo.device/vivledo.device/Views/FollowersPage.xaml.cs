using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vivledo.device.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vivledo.device.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FollowersPage : ContentPage
    {
        public FollowersPage()
        {
            InitializeComponent();
            BindingContext = new FollowersViewModel();
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