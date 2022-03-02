using ProsApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProsApp.Views
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