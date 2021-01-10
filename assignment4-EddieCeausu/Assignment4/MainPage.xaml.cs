using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment4
{
    public partial class MainPage : ContentPage
    {
        double bill, tip;

        public MainPage()
        {
            InitializeComponent();
            
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if(Bill.Text != String.Empty && Tip.Text != String.Empty)
                result.Text = "Result: $" + (bill + (bill * tip / 100)).ToString();
            else
            {
                billLabel.TextColor = Color.Red;
                tipLabel.TextColor = Color.Red;
            }
        }

        void Tip_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue.ToString() == String.Empty)
            {
               // Error Control Here
            }
            else
            {
                tip = Double.Parse(e.NewTextValue.ToString());
            }
        }

        void Bill_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

            if (e.NewTextValue.ToString() == String.Empty)
            {
                // Error Control Here
            }
            else
            {
                bill = Double.Parse(e.NewTextValue.ToString());
            }
        }
    }
}
