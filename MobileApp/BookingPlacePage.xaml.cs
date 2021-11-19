using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp
{
    public partial class BookingPlacePage : ContentPage
    {
        public BookingPlacePage()
        {
            InitializeComponent();
        }

        private async void BookPlace(object sender, EventArgs e)
        {
            await DisplayAlert("Successful", "We are waiting for you in our restaurant", "To the main page");
            await Navigation.PopAsync();
        }

        private async void OccupiedPlace(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("You can't book this place", "The place is occupied", "OK");
        }
    }
}
