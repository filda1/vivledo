using vivledo.device.Views;

using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using System.Windows.Input;

namespace vivledo.device.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion


        public LoginViewModel()
        {
            //LoginCommand = new Command(OnLoginClicked);
            //SinginCommand = new Command(DisplayAccount);

            //this.apiService = new ApiService();

            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = " ola@gmail.com";
            this.Password = "123";


        }

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }



        private async void Login()
        {

            var mainViewModel = MainViewModel.GetInstance();
            //mainViewModel.Token = token;
           // mainViewModel.Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AppShell());

            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;
        }
        #endregion


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
