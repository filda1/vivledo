using vivledo.device.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace vivledo.device.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        //public Command LoginCommand { get; }
        public Command SinginCommand { get; }

        public LoginViewModel()
        {
            //LoginCommand = new Command(OnLoginClicked);
            SinginCommand = new Command(DisplayAccount);


        }

        //public ICommand SinginCommand => new Command(DisplayAccount);
        private void DisplayAccount()
        {
            var RegisterPage = new RegisterPage();

            var navigation = Application.Current.MainPage as NavigationPage;
            navigation.PushAsync(RegisterPage, true);
        }
    

      /*  private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }*/

    }
}
