using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using vivledo.device.Models;

namespace vivledo.device.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<Menu> menu { get; set; }
        public ObservableCollection<PopularFood> popularFood { get; set; }

        //private List<PostItem> ListPosts = new List<PostItem>();

        public HomeViewModel()
        {

            menu = new ObservableCollection<Menu>
            {
                new Menu
                {
                    Picture = "Burger",
                    Name = "Burger"
                },
                new Menu
                {
                    Picture = "Dessert",
                    Name = "Dessert"
                },
                new Menu
                {
                    Picture = "Pizza",
                    Name = "Pizza"
                },
                new Menu
                {
                    Picture = "Burger",
                    Name = "Burger"
                },
                new Menu
                {
                    Picture = "Dessert",
                    Name = "Dessert"
                },
                new Menu
                {
                    Picture = "Pizza",
                    Name = "Pizza"
                }
            };



            popularFood = new ObservableCollection<PopularFood>
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
            };

        }

    }

}
    
   
