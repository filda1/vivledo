using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using vivledo.device.Models;

namespace vivledo.device.ViewModels
{
    public class FollowingViewModel : BaseViewModel
    {
        public ObservableCollection<Following> Following { get; set; }

        public ObservableCollection<Menu> menu { get; set; }

        public FollowingViewModel()
        {
            Title = "Following";

            Following = new ObservableCollection<Following>
            {
                new Following
                {
                    Picture = "person2",
                    Name = "Burger"
                },
                new Following
                {
                    Picture = "person2",
                    Name = "Dessert"
                },
                 new Following
                {
                    Picture = "person2",
                    Name = "Pizza"
                },
                new Following
                {
                    Picture = "person2",
                    Name = "Burger"
                },
                 new Following
                {
                    Picture = "person2",
                    Name = "Dessert"
                },
                 new Following
                {
                    Picture = "person2",
                    Name = "Pizza"
                }
            };




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
        }
    }
}
