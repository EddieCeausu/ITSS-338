using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment5
{
    public partial class MainPage : ContentPage
    {
        int compYear;
        double startInvest, monthInvest, numYears, intRate;
        public MainPage()
        {
            InitializeComponent();

        }

        private double CalculateTotal(double initialInvestment,
                                      double monthlyInvestment,
                                      double numberOfYears,
                                      int compoundsPerYear,
                                      double interestRate)
        {
            var periodicInvestment = monthlyInvestment * 12 / compoundsPerYear;
            interestRate /= 100;
            var innerCalculation = Math.Pow(1 + interestRate / compoundsPerYear, compoundsPerYear * numberOfYears);
            var compoundInterestForPrinciple = initialInvestment * innerCalculation;
            var futureValueOfSeries = periodicInvestment * (innerCalculation - 1) * (compoundsPerYear / interestRate);
            return compoundInterestForPrinciple + futureValueOfSeries;
        }

        void Switch_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            if (isToggled)
            {
                totalLabel.IsVisible = true;
            }
            else
            {
                totalLabel.IsVisible = false;
            }
        }

        void stepper_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            numYears = e.NewValue;
        }

        void slider1_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            monthInvest = e.NewValue;
        }

        void slider2_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            intRate = e.NewValue;
        }

        void cInterval_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            switch (cInterval.SelectedIndex)
            {
                case 0:
                    compYear = 365;
                    break;
                case 1:
                    compYear = 12;
                    break;
                case 2:
                    compYear = 1;
                    break;
            }
        }

        void initInvest_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue.ToString() == String.Empty)
            {
                // Error Control Here
            }
            else
            {
                try
                {
                    startInvest = Double.Parse(e.NewTextValue.ToString());
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Error when parsing double for start Invest", exp);
                    throw exp;
                }
            }
        }

        void Calculate_Clicked(System.Object sender, System.EventArgs e)
        {
            double total = 0;
            try
            {
                total = CalculateTotal(startInvest, monthInvest, numYears, compYear, intRate);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Throw Error for application checking here.", exp);
                throw exp;
            }
            totalLabel.Text = "Total: " + total.ToString("C");
        }
    }
 }

