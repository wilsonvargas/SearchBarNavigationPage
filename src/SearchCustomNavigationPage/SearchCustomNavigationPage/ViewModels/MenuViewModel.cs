using SearchCustomNavigationPage.Model;
using SearchCustomNavigationPage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchCustomNavigationPage.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private List<MasterPageItem> _items;

        public List<MasterPageItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MenuViewModel()
        {
            Items = new List<MasterPageItem>();
            Load();
        }

        private void Load()
        {
            Items.Add(new MasterPageItem
            {
                Title = "Main",
                Icon = "icon.png",
                Target = typeof(Page1)
            });
            Items.Add(new MasterPageItem
            {
                Title = "Page 2",
                Icon = "icon.png",
                Target = typeof(Page2)
            });
        }

    }
}
