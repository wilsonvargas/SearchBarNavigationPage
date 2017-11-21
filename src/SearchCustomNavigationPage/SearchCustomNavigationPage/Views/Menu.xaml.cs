using SearchCustomNavigationPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchCustomNavigationPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public ListView ListView { get { return navigationDrawerList; } }
        public Menu()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }
    }
}