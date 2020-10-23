using System;
using System.Collections.Generic;
using BadgeTest.ViewModels;
using BadgeTest.Views;
using Xamarin.Forms;

namespace BadgeTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
