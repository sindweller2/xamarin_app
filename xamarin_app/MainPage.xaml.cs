using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        async void Click_Clicked(object sender, System.EventArgs e)
        {
            count++;
            await DisplayAlert("Click!",
                $"You clicked {count} times.",
                "OK");
        }

        async void Reset_Clicked(object sender, System.EventArgs e)
        {
            count = 0;
            await DisplayAlert("Reset!",
                "You reset clicked",
                "OK");
        }
    }
}
