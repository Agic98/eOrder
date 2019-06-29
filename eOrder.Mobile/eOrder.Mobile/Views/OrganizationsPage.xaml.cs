using eOrder.Mobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationsPage : ContentPage
    {
        OrganizationsViewModel model = null;
        public OrganizationsPage()
        {
            InitializeComponent();
            BindingContext = model = new OrganizationsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        public async void OpenOrganizationProfile(object sender, EventArgs e)
        {
            var id = (int)(((Button)sender).BindingContext);
            await Navigation.PushModalAsync(new NavigationPage(new OrganizationProfilePage(id)));
        }

        public async void OpenFiltersForOrganizations(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FiltersPage(this.model)));
        }
    }
}