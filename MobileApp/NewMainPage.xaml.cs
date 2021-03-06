using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using Xamarin.Forms;

namespace MobileApp
{
    public partial class NewMainPage : TabbedPage
    {
        //public NewMainPage()
        //{
        //    InitializeComponent();
        //}

        User newUser;

        public NewMainPage(User user)
        {
            InitializeComponent();

            newUser = user;

            nameLabel.Text += user.Name;
            emailLabel.Text += user.Email;
            phoneLabel.Text += user.Phone;
            cityLabel.Text += user.City;

            //Grid restaurans = new Grid { };

            //restaurans.Children.Add(new Image { Source = "CheChilPub.jpeg" }, 0, 0);
            //restaurans.Children.Add(new Image { Source = "Saksaul.jpeg" }, 0, 0);
            //restaurans.Children.Add(new Image { Source = "OceanBasket.jpg" }, 0, 0);

            //TabbedPage.Conte = restaurans;

            /*Application.Current.MainPage = new NavigationPage(new MobileApp.NewMainPage())
            {
                BackgroundColor = Color.FromHex("#f3e5f5"),
                BarBackgroundColor = Color.FromHex("#7c4dff")
            };*/

            //SaveUser(user);

            //User restoredUser;

            /*using (FileStream fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                restoredUser = JsonSerializer.Deserialize<User>(fs);
                //Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
            }*/

            //string jsonString = File.ReadAllText("Users/sanya/Projects/MobileApp/MobileApp/users.json");
            //User restoredUser = JsonSerializer.Deserialize<User>(jsonString);
        }

        public async void SaveUser(User user)
        {
            using (FileStream fs = new FileStream("usersList.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, user);
            }
        }

        public async void CreateAccountInfo()
        {
            User restoredUser;

            using (FileStream fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                restoredUser = await JsonSerializer.DeserializeAsync<User>(fs);
            }

            nameLabel.Text = restoredUser.Email;
            phoneLabel.Text = restoredUser.Phone;
        }

        private async void BookPlace(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MobileApp.BookingPlacePage());
        }
    }
}
