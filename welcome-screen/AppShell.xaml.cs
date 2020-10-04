using System;
using System.Collections.Generic;
using welcome_screen.ViewModels;
using welcome_screen.Views;
using Xamarin.Forms;

namespace welcome_screen
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
