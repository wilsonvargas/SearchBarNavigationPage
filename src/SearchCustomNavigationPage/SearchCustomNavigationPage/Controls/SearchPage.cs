﻿using System.Windows.Input;
using Xamarin.Forms;

namespace SearchCustomNavigationPage.Controls
{
    public class SearchPage : ContentPage
    {
        public ICommand SearchCommand
        {
            get
            {
                return (ICommand)GetValue(SearchCommandProperty);
            }
            set
            {
                SetValue(SearchCommandProperty, value);
            }
        }

        public string SearchPlaceHolderText
        {
            get
            {
                return (string)GetValue(SearchPlaceHolderTextProperty);
            }
            set
            {
                SetValue(SearchPlaceHolderTextProperty, value);
            }
        }

        public string SearchText
        {
            get
            {
                return (string)GetValue(SearchTextProperty);
            }
            set
            {
                SetValue(SearchTextProperty, value);
            }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create(nameof(SearchCommand),
                typeof(ICommand),
                typeof(SearchPage));

        public static readonly BindableProperty SearchPlaceHolderTextProperty =
                                            BindableProperty.Create(nameof(SearchPlaceHolderText),
                typeof(string),
                typeof(SearchPage),
                string.Empty);

        public static readonly BindableProperty SearchTextProperty =
            BindableProperty.Create(nameof(SearchText),
                typeof(string),
                typeof(SearchPage),
                string.Empty);
    }
}
