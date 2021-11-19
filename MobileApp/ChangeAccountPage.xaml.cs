using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp
{
    public partial class ChangeAccountPage : ContentPage
    {
        public ChangeAccountPage(User receivedUser)
        {
            InitializeComponent();

            nameEntry.Text = receivedUser.Name;
            emailEntry.Text = receivedUser.Email;
            phoneEntry.Text = receivedUser.Phone;
            cityEntry.Text = receivedUser.City;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
