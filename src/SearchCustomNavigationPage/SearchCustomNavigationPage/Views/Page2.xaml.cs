using SearchCustomNavigationPage.Controls;
using SearchCustomNavigationPage.ViewModels;
using Xamarin.Forms.Xaml;

namespace SearchCustomNavigationPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : SearchPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new SearchPageViewModel();
        }
    }
}
