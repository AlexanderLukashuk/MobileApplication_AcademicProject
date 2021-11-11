using System;
namespace MobileApp
{
    public class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        private string Password { get; set; }

        public User(string name, string email, string phone,  string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}
