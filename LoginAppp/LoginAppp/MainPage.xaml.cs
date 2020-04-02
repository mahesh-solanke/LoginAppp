using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginAppp
{ 
    public partial class MainPage : ContentPage { 
    public MainPage()
    {
            //InitializeComponent();
    }

    private void LoginEvent(object sender, EventArgs e)
    {
        DisplayAlert("Login", "Login is Successful", "ok");
    }
}
}
