using SearchCustomNavigationPage.Model;
using SearchCustomNavigationPage.Views;
using System.Collections.Generic;

namespace SearchCustomNavigationPage.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel()
        {
            Items = new List<MasterPageItem>();
            Load();
        }

        public List<MasterPageItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        private List<MasterPageItem> _items;

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
