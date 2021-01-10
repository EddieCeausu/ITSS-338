using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment6
{
    
    public partial class MainPage : ContentPage
    {
        private string selectedItem;
        private System.Object temp;
        public MainPage()
        {
            InitializeComponent();

            List<Items> menu = new List<Items>
            {
                new Items {Name = "BBQ Chicken", Price = (new Random().NextDouble() * 10) + 2},
                new Items {Name = "Buffalo Chicken", Price = (new Random().NextDouble() * 10) + 2},
                new Items {Name = "Chicken Bacon Ranch Melt", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Black Forest Ham", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Spicy Italian Chicken", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Sweet Onion Teriyaki Chicken", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Turkey Cheese Delight", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Original", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Italian Classic", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Veggitarian", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Vegan", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Gargantuan", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Gentlemens Club", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Country Club", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Beach Club", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Bootleggers Club", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Tuna Salad", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Pizza Original", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Friendship", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The Athlete", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Sniper, POW", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Jimmy Johns", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Subway", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "Burger King", Price = (new Random().NextDouble() * 10) + 2 },
                new Items {Name = "The ripoff", Price = (new Random().NextDouble() * 10) + 2 }
            };

            MenuList.ItemsSource = menu;
        }

        async void MenuList_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Items item = (Items) e.Item;
            
            await DisplayAlert("Priority Sandwich", "Are you sure you want to select  " + item.Name + "?", "Yes");
            
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (selectedItem == null) { await DisplayAlert("Priority Sandwich", "Please select an item first", "Ok"); }
            else { ((ListView)temp).SelectedItem = null;  }
        }
    }

    public class Items
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
