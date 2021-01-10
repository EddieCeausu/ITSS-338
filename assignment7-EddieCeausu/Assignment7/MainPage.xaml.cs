using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            mainPage.ItemsSource = new Pages[]
            {
                new Pages {Title="Connections", Description="Wifi and Data settings"},
                new Pages {Title="Sounds and Vibrations", Description="Ringtone and Notification settings"},
                new Pages {Title="Display", Description="Brightness, Resolution, Font Style, and Wallpaper"},
                new Pages {Title="Lockscreen", Description="Screen Lock Type, Lockscreen Style, and Wallpaper"}
            };
        }

        protected async void mainPage_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = e.Item as Pages;
            if (item == null) return;
            await Navigation.PushAsync(new SamplePage(item));
            mainPage.SelectedItem = null;
        }
    }
}
