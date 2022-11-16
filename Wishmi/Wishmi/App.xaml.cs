using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wishmi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
