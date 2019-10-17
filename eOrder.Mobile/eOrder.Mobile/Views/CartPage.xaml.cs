using eOrder.Mobile.Services;
using eOrder.Mobile.ViewModels;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        CartViewModel model = null;
        public CartPage()
        {
            InitializeComponent();
            BindingContext = model = new CartViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        async void InitiateOrder(object sender, EventArgs e)
        {
            var orderId = (int)((Button)sender).BindingContext;
            await model.InitiateOrder(orderId);
        }

        async void InitiateOrders(object sender, EventArgs e)
        {
            await model.InitiateOrders();
        }

        private async void EditFromCart(object sender, EventArgs e)
        {
            var orderDetailId = (int)(((Button)sender).BindingContext);
            await Navigation.PushModalAsync(new NavigationPage(new OrderDetailRequestPage(orderDetailId, null)));
        }

        private async void Details(object sender, EventArgs e)
        {
            var orderId = (int)(((Button)sender).BindingContext);
            await Navigation.PushModalAsync(new NavigationPage(new OrderPage(orderId, true)));
        }
    }
}