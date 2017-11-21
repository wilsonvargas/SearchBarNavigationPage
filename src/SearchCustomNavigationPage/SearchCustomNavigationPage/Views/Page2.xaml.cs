using SearchCustomNavigationPage.Controls;
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
    public partial class Page2 : SearchPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new SearchPageViewModel();
        }
    }
}