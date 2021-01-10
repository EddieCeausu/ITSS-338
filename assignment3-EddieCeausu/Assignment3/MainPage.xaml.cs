using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Grades 
        private void Refresh1(object sender, EventArgs e)
        {
            grade1.Text = new Random().Next(0, 101).ToString() + "%";
        }
        // Assignments
        private void Refresh2(object sender, EventArgs e)
        {
            grade2.Text = new Random().Next(0, 10).ToString();
        }
        // Messages 
        private void Refresh3(object sender, EventArgs e)
        {
            grade3.Text = new Random().Next(0, 5).ToString();
        }
    }
}
