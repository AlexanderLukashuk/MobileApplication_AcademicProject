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

            //User user = new User(loginEntry.Text, phoneEntry.Text, passwordEntry.Text);
            //string jsonString = JsonSerializer.Serialize(user);
            //File.WriteAllText("usersList.json", jsonString);

            //XmlSerializer formatter = new XmlSerializer(typeof(User));

            //using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, user);
            //}

            //using FileStream createStream = File.Create("users.json");
            //await JsonSerializer.SerializeAsync(createStream, user);

            await Navigation.PushAsync(new MobileApp.NewMainPage());
        }
    }
}
