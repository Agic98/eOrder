using eOrder.Mobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        OrderViewModel model = null;

        public OrderPage(int id, bool isEditable)
        {
            InitializeComponent();
            BindingContext = this.model = new OrderViewModel(id, isEditable);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void EditFromCart(object sender, EventArgs e)
        {
            var orderDetailId = (int)(((Button)sender).BindingContext);
            await Navigation.PushModalAsync(new NavigationPage(new OrderDetailRequestPage(orderDetailId, null)));
        }
    }
}