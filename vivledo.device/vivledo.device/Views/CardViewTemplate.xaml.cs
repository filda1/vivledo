using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vivledo.device.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardViewTemplate : ContentView
    {
        public CardViewTemplate()
        {
            InitializeComponent();
        }

        private void ActionsToogle(object sender, ToggledEventArgs e)
        {
            bool isToogled = e.Value;
            mainLabel.Text = isToogled.ToString();
        }
    }
}