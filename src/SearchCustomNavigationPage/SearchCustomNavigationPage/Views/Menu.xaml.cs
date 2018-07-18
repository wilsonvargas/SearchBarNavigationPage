using SearchCustomNavigationPage.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchCustomNavigationPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }

        public ListView ListView { get { return navigationDrawerList; } }
    }
}
