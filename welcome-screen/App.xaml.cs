using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using welcome_screen.Services;
using welcome_screen.Views;
using Xamarin.Essentials;

namespace welcome_screen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Preferences.Get("Welcome", true);
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
