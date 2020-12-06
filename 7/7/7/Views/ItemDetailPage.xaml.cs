using System.ComponentModel;
using Xamarin.Forms;
using _7.ViewModels;

namespace _7.Views
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