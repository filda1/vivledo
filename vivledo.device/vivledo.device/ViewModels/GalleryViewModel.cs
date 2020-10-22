using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using vivledo.device.Models;

namespace vivledo.device.ViewModels
{
    public class GalleryViewModel:BaseViewModel
    {
        public ObservableCollection<Menu> menu { get; set; }
        public ObservableCollection<PopularFood> popularFood { get; set; }


        public IList<PopularFood> CardViewCollection { get; set; }
        public object SelectedItem { get; set; }

        public GalleryViewModel()
        {
            Title = "Media";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));

            CardViewCollection = new List<PopularFood>();
            GerarCardViewModel();

            menu = new ObservableCollection<Menu>
            {
                new Menu
                {
                    Picture = "homeicon",
                    Name = "Burger"
                },
                new Menu
                {
                    Picture = "groupicon",
                    Name = "Dessert"
                },
                new Menu
                {
                    Picture = "friendicon",
                    Name = "Pizza"
                },
                new Menu
                {
                    Picture = "notificationicon",
                    Name = "Burger"
                },
                new Menu
                {
                    Picture = "photoicon",
                    Name = "Dessert"
                },
                new Menu
                {
                    Picture = "photoicon",
                    Name = "Pizza"
                }
            };



            /* popularFood = new ObservableCollection<PopularFood>
             {
                 new PopularFood
                 {
                     Picture="Option1",
                     Name="Millonario State Cafe",
                     Description="Deli - Pizza - Breakfast and Brunch",
                     Rating=" 4.5 (98) ",
                     IntervalTime="10-15 min"
                 },
                 new PopularFood
                 {
                     Picture="Option2",
                     Name="Burger State",
                     Description="Burgers - Pizza",
                     Rating=" 4.0 (90) ",
                     IntervalTime="10-15 min"
                 },
                 new PopularFood
                 {
                     Picture="Option3",
                     Name="Burger Burger",
                     Description="Breakfast and Brunch",
                     Rating=" 4.9 (100) ",
                     IntervalTime="10-15 min"
                 }
             };*/


        }

        private void GerarCardViewModel()
        {
            CardViewCollection = new ObservableCollection<PopularFood>
            {

                new PopularFood
                {
                    Picture="Option1",
                    Name="Millonario State Cafe",
                    Imagem="person2.jpg",
                    Description="Deli - Pizza - Breakfast and Brunch",
                    Rating=" 4.5 (98) ",
                    IntervalTime="10-15 min",
                    Nicons ="123",
                    Comments="wwww",
                    Like="like",
                    Mensages="..."
                },
                new PopularFood
                {
                    Picture="Option2",
                    Name="Burger State",
                    Imagem="person2.jpg",
                    Description="Burgers - Pizza",
                    Rating=" 4.0 (90) ",
                    IntervalTime="10-15 min",
                    Nicons ="123",
                    Comments="wwww",
                    Like="like",
                    Mensages="..."
                },
                new PopularFood
                {
                    Picture="Option3",
                    Name="Burger Burger",
                    Imagem="person2.jpg",
                    Description="Breakfast and Brunch",
                    Rating=" 4.9 (100) ",
                    IntervalTime="10-15 min",
                    Nicons ="123",
                    Comments="wwww",
                    Like="like",
                    Mensages="..."
                }
            };
        }
    }
}