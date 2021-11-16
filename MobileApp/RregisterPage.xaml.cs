using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using Xamarin.Forms;

namespace MobileApp
{
    public partial class RregisterPage : ContentPage
    {
        public RregisterPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            //Label1.Text = "Hello " + loginEntry.Text;
            //User user = new User(loginEntry.Text, phoneEntry.Text, passwordEntry.Text);
            //UsersList.usersList.Add(user);

            /*using (FileStream fs = new FileStream("usersList.json", FileMode.OpenOrCreate))
            {
                User user = new User(loginEntry.Text, phoneEntry.Text, passwordEntry.Text);
                await JsonSerializer.SerializeAsync(fs, user);
            }*/

            string name = nameEntry.Text;
            string email = loginEntry.Text;
            string phone = phoneEntry.Text;
            string password = passwordEntry.Text;
            string city = cityEntry.Text;

            if (String.IsNullOrEmpty(name))
            {
                await DisplayAlert("Error", "Name field must be filled", "Ok");
            }
            else if (String.IsNullOrEmpty(email))
            {
                await DisplayAlert("Error", "Email field must be filled", "Ok");
            }
            else if (String.IsNullOrEmpty(phone))
            {
                await DisplayAlert("Error", "Phone foeld must be filled", "Ok");
            }
            else if (String.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Password field must be filled", "Ok");
            }
            else if (!(IsValidEmail(email)))
            {
                await DisplayAlert("Error", "Wrong email address", "Ok");
            }
            else if (phone.Length != 11)
            {
                await DisplayAlert("Error", "Wrong phone number", "Ok");
            }
            else
            {
                User user = new User(name, email, phone, password);

                await DisplayAlert("Wait", "Successful", "OK");
                await Navigation.PushAsync(new MobileApp.NewMainPage(user));
            }


            //string jsonString = JsonSerializer.Serialize(user);
            //File.WriteAllText("usersList.json", jsonString);

            //XmlSerializer formatter = new XmlSerializer(typeof(User));

            //using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, user);
            //}

            //using FileStream createStream = File.Create("users.json");
            //await JsonSerializer.SerializeAsync(createStream, user);

            //await Navigation.PushAsync(new MobileApp.NewMainPage(user));
            //await Navigation.PushAsync(new MobileApp.NewMainPage(user));
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
