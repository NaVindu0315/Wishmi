using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wishmi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }
        public String usename;
        public String pw;

        private void Button_Clicked(object sender, EventArgs e)
        {
            
           
            if(usename.Equals("admin"))
            {
                if (pw.Equals("admin123"))
                {
                    App.Current.MainPage = new first();
                }
                else
                {
                    DisplayAlert("Invalid Password","You have entered a wrong password","ok");
                }
            }
            else
            {
                DisplayAlert("Invalid Username", "Username Doesnt exist", "OK");
            }
        }

        private void username_Completed(object sender, EventArgs e)
        {
            string name = ((Entry)sender).Text;
            usename = name;
        }

        private void Password_Completed(object sender, EventArgs e)
        {
            string pw = ((Entry)sender).Text;

        }
    }
}