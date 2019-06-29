using eOrder.Mobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationProfilePage : ContentPage
    {
        OrganizationViewModel model = null;
        int Id;

        public OrganizationProfilePage(int id)
        {
            InitializeComponent();
            Id = id;
            BindingContext = this.model = new OrganizationViewModel(id);
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

        private async void AddToCart(object sender, EventArgs e)
        {
            var productId = (int)(((Button)sender).BindingContext);
            await Navigation.PushModalAsync(new NavigationPage(new OrderDetailRequestPage(null, productId)));
        }
    }
}