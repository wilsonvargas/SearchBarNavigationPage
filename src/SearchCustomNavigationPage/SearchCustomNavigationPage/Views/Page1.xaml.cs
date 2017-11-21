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