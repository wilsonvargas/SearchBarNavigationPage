﻿using SearchCustomNavigationPage.Model;
using System;
using Xamarin.Forms;

namespace SearchCustomNavigationPage.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Master = menuPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Page1)));
            menuPage.ListView.ItemSelected += OnItemSelected;
            MasterBehavior = MasterBehavior.Popover;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                menuPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
