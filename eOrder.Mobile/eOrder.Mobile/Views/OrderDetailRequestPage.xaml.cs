using eOrder.Mobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetailRequestPage : ContentPage
    {
        OrderDetailRequestViewModel model = null;
        public OrderDetailRequestPage(int? orderDetailId, int? productId)
        {
            InitializeComponent();
            BindingContext = model = new OrderDetailRequestViewModel(orderDetailId, productId);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        protected async void SaveOrderDetail(object sender, EventArgs e)
        {
            var success = await model.Save();
            if (success)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Successfully saved.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Error happened while saving.", "OK");
            }
            await Navigation.PopModalAsync();
        }
    }
}