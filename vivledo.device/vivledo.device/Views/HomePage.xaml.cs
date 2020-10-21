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
    public partial class HomePage : ContentPage
    {

        ItemsViewModel _viewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new HomeViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}