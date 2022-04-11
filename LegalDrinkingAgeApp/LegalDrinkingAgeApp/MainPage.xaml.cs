using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LegalDrinkingAgeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            int userAge = Int32.Parse(Age.Text);
            int legalAge = 21;

            if(userAge >= legalAge)
            {
                TheLabel.Text = $"You are able to drink, you are {userAge} years old";
                YearsUntilLabel.Text = "";
            } else
            {
                TheLabel.Text = $"You cannot drink, you are {userAge} years old";
                YearsUntilLabel.Text = $"You can drink in {legalAge - userAge} year(s)";
            }
            
            
        }
    }
}
