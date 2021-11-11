using System;
namespace MobileApp
{
    public class User
    {
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public string Phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }

        private string Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }

        public User(string email, string phone,  string password)
        {
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}
