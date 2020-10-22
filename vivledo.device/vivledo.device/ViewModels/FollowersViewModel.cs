using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using vivledo.device.Models;

namespace vivledo.device.ViewModels
{
    public class FollowersViewModel:BaseViewModel
    {
        public ObservableCollection<Followers> Followers { get; set; }

        public ObservableCollection<Menu> menu { get; set; }

        public FollowersViewModel()
        {
            Title = "Followers";

            Followers = new ObservableCollection<Followers>
            {
                new Followers
                {
                    Picture = "person2",
                    Name = "Burger"
                },
                 new Followers
                {
                    Picture = "person2",
                    Name = "Dessert"
                },
                 new Followers
                {
                    Picture = "person2",
                    Name = "Pizza"
                },
                 new Followers
                {
                    Picture = "person2",
                    Name = "Burger"
                },
                  new Followers
                {
                    Picture = "person2",
                    Name = "Dessert"
                },
                  new Followers
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
