using System;
namespace MobileApp
{
    public class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        private string Password { get; set; }

        public User(string name, string email, string phone, string city, string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            City = city;
            Password = password;
        }
    }
}
