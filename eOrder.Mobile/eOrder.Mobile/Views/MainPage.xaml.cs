using eOrder.Mobile.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [AdMaiora.RealXaml.Client.MainPage]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            AdMaiora.RealXaml.Client.AppManager.Init(this);
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new OrganizationsPage()));
                        break;
                    case (int)MenuItemType.Search:
                        MenuPages.Add(id, new NavigationPage(new SearchPage()));
                        break;
                    case (int)MenuItemType.Cart:
                        MenuPages.Add(id, new NavigationPage(new CartPage()));
                        break;
                    case (int)MenuItemType.OrdersHistory:
                        MenuPages.Add(id, new NavigationPage(new OrdersHistoryPage()));
                        break;
                    case (int)MenuItemType.OrdersActive:
                        MenuPages.Add(id, new NavigationPage(new OrdersActivePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}