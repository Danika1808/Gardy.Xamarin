using Gardy.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Gardy.Views
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