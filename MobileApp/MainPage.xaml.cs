using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RegisterClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MobileApp.RregisterPage());
        }

        private async void LoginClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MobileApp.LoginPage());
        }
    }
}
