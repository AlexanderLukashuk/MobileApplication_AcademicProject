﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileApp
{
    public partial class RregisterPage : ContentPage
    {
        public RregisterPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Label1.Text = "Hello " + loginEntry.Text;
        }
    }
}