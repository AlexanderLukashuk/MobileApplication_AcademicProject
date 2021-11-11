using System;
namespace MobileApp
{
    public class User
    {
        public string Email { get; set; }

        public string Phone { get; set; }

        private string Password { get; set; }

        public User(string email, string phone,  string password)
        {
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}
