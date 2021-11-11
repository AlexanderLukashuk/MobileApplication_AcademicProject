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
        public NewMainPage()
        {
            InitializeComponent();

            //SaveUser(user);

            //User restoredUser;

            /*using (FileStream fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                restoredUser = JsonSerializer.Deserialize<User>(fs);
                //Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
            }*/

            //string jsonString = File.ReadAllText("Users/sanya/Projects/MobileApp/MobileApp/users.json");
            //User restoredUser = JsonSerializer.Deserialize<User>(jsonString);

            //nameLabel.Text = restoredUser.Email;
            //phoneLabel.Text = restoredUser.Phone;

            //nameLabel.Text = user.Email;
            //phoneLabel.Text = user.Phone;
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

    }
}
