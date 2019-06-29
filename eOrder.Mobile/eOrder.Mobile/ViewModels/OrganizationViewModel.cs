using eOrder.CORE.Requests;
using eOrder.Mobile.Helpers;
using eOrder.Mobile.Models;
using eOrder.Mobile.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class OrganizationViewModel : BaseViewModel
    {
        APIService _productService = new APIService("Product");
        APIService _organizationService = new APIService("Organization");
        ICommand InitCommand { get; set; }

        int organizationId;
        OrganizationDTO _organization;
        public OrganizationDTO Organization { get { return _organization; } set { SetProperty(ref _organization, value); } }
        string _profilePhoto;
        public string ProfilePhoto { get { return _profilePhoto; } set { SetProperty(ref _profilePhoto, value); } }
        public ObservableCollection<UserRatingDTO> Ratings { get; set; } = new ObservableCollection<UserRatingDTO>();
        public ObservableCollection<ProductModel> Products { get; set; } = new ObservableCollection<ProductModel>();
        public string TotalRating { get; set; } = "0";
        public string TotalNumberOfRatings { get; set; } = "0";

        public OrganizationViewModel()
        {

        }

        public OrganizationViewModel(int id)
        {
            organizationId = id;
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            Organization = await _organizationService.GetById<OrganizationDTO>(organizationId);

            ProfilePhoto = $"{APIService._apiUrl}/Organization/ProfilePhoto/{Organization.Id}";

            Cart.CurrentOrganization = Organization.Id;

            var products = await _productService.Get<IEnumerable<ProductDTO>>(new ProductSearchRequest { OrganizationId = Organization.Id });
            Products.Clear();
            foreach (var item in products)
            {
                Products.Add(new ProductModel
                {
                    Product = item,
                    PhotoUrl = $"{APIService._apiUrl}/Product/Photo/{item.Id}"
                });
            }
        }
    }
}
