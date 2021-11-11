using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileApp
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            foreach (var item in UsersList.usersList)
            {
                Email.Text = item.Email;
                Phone.Text = item.Phone;
            }
        }
    }
}
