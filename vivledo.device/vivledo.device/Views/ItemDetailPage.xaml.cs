using System.ComponentModel;
using Xamarin.Forms;
using vivledo.device.ViewModels;

namespace vivledo.device.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}