using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace welcomescreen.Views.pop
{
    public partial class WelcomePop :PopupPage 
    {
        public WelcomePop()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // apagamos el Welcome screen
            Preferences.Set("Welcome", false);
            await Navigation.PopAllPopupAsync();
        }
    }
}
