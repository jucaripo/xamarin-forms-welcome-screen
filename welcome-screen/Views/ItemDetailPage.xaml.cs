using System.ComponentModel;
using Xamarin.Forms;
using welcome_screen.ViewModels;

namespace welcome_screen.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}