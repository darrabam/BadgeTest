using System.ComponentModel;
using Xamarin.Forms;
using BadgeTest.ViewModels;

namespace BadgeTest.Views
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