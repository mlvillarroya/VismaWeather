using VismaWeather.ViewModels;
using Xamarin.Forms;

namespace VismaWeather.Views
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
