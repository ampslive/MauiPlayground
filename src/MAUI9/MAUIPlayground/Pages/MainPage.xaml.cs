using MAUIPlayground.Models;
using MAUIPlayground.PageModels;

namespace MAUIPlayground.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}