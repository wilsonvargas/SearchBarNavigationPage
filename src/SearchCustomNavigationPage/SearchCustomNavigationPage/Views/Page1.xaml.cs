using SearchCustomNavigationPage.Controls;
using SearchCustomNavigationPage.ViewModels;
using Xamarin.Forms.Xaml;

namespace SearchCustomNavigationPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : SearchPage
    {
        public Page1()
        {
            InitializeComponent();
            //NavigationPage.SetTitleIcon(this,"icon.png");
            BindingContext = new SearchPageViewModel();
        }
    }
}
