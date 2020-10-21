﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vivledo.mobile.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vivledo.mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
            
        }
    }
}