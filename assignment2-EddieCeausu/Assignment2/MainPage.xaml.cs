using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Assignment2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void onClick1(object sender, EventArgs e) {
            //showTime.Text = DateTime.Now.ToString();
            showTime.Text = DateTime.Now.ToString();
        }
        private void onClick2(object sender, EventArgs e)
        {
            rollDie.Text = new Random().Next(0, 2) == 0 ? "Heads!" : "Tails!";
        }
        //private void onClick3(object sender, EventArgs e)
        //{
        //    randomText.Text = new Quotes().getQuote();
        //}
    }
}
