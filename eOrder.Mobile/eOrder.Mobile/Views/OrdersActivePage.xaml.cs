using eOrder.CORE.Constants;
using eOrder.Mobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersActivePage : ContentPage
    {
        OrdersViewModel model = null;
        public OrdersActivePage()
        {
            InitializeComponent();
            BindingContext = model = new OrdersViewModel(OrderStatus.Processing);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Details(object sender, EventArgs e)
        {
            var orderId = (int)(((Button)sender).BindingContext);
            await Navigation.PushModalAsync(new NavigationPage(new OrderPage(orderId, false)));
        }
    }
}