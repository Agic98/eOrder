
using eOrder.Mobile.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FiltersPage : ContentPage
    {
        OrganizationsViewModel model = null;
        public FiltersPage(OrganizationsViewModel model)
        {
            InitializeComponent();
            BindingContext = this.model = model;
        }

        public async void SaveFiltersOpenOrganizationsPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}