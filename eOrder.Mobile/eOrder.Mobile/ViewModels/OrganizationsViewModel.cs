using eOrder.CORE.Requests;
using eOrder.Mobile.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class OrganizationsViewModel : BaseViewModel
    {
        APIService _organizationsService = new APIService("Organization");
        public ObservableCollection<OrganizationModel> Organizations { get; set; } = new ObservableCollection<OrganizationModel>();
        public ICommand InitCommand { get; set; }


        public OrganizationsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        #region Filters
        double _ratingMin = 0;
        public double RatingMin { get { return _ratingMin; } set { SetProperty(ref _ratingMin, value); }}

        double _distanceKilometers = 0;
        public double DistanceKilometers { get { return _distanceKilometers; } set { SetProperty(ref _distanceKilometers, value); } }

        double _deliveryTimeMinutes = 0;
        public double DeliveryTimeMinutesMax { get { return _deliveryTimeMinutes; } set { SetProperty(ref _deliveryTimeMinutes, value); } }

        double _averagePriceMax = 0;
        public double AveragePriceMax { get { return _averagePriceMax; } set { SetProperty(ref _averagePriceMax, value); } }
        #endregion

        public async Task<OrganizationDTO> GetOrganizationById(int id)
        {
            return await _organizationsService.GetById<OrganizationDTO>(id);
        }

        public async Task Init()
        {
            var data = await _organizationsService.Get<IEnumerable<OrganizationDTO>>(
                new OrganizationSearchRequest {
                    RatingMin = RatingMin,
                    DistanceKilometers = DistanceKilometers,
                    DeliveryTimeMinutesMax = DeliveryTimeMinutesMax,
                    AverageProductPriceMax = AveragePriceMax,
                    OrganizationType = new OrganizationTypeDTO()
                });

            Organizations.Clear();
            foreach (var item in data)
            {
                Organizations.Add(new OrganizationModel
                {
                    Organization = item,
                    ProfilePhoto = $"{APIService._apiUrl}/Organization/ProfilePhoto/{item.Id}"
                });
            }
        }
    }
}
