using eOrder.Mobile.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace eOrder.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Search, Title="Search" },
                new HomeMenuItem {Id = MenuItemType.Cart, Title="Cart" },
                new HomeMenuItem {Id = MenuItemType.OrdersHistory, Title="Orders history" },
                new HomeMenuItem {Id = MenuItemType.OrdersActive, Title="Acitve orders" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}