using System;
using System.ComponentModel;
using Rg.Plugins.Popup.Services;
using welcomescreen.Views.pop;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace welcome_screen.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            
            if (Preferences.Get("Welcome",true) == true)
            {
                //mostrar bienvenida
                PopupNavigation.Instance.PushAsync(new WelcomePop());
            }
            
        }
    }
}