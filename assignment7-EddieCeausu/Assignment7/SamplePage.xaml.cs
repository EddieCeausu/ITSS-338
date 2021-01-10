using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment7
{
    public partial class SamplePage : ContentPage
    {
        public SamplePage(Pages page)
        {
            InitializeComponent();
            this.BindingContext = page;
        }

        protected async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage()); 
        }
    }
}
