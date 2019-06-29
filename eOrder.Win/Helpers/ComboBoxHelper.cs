using eOrder.CORE.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrder.Win.Helpers
{
    public class ComboBoxHelper
    {
        APIService _countryAPIService = new APIService("Country");
        APIService _currencyAPIService = new APIService("Currency");
        APIService _vehicleTypeAPIService = new APIService("VehicleType");
        APIService _organizationTypeAPIService = new APIService("OrganizationType");
        APIService _cityAPIService = new APIService("City");
        APIService _userAPIService = new APIService("User");
        APIService _roleAPIService = new APIService("Role");
        APIService _categoryAPIService = new APIService("Category");

        public async Task<ComboBox> GetCountries(ComboBox cbx)
        {
            var data = await _countryAPIService.Get<List<CountryDTO>>(null);
            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem
                {
                    Value = item.Id,
                    DisplayText = item.Name
                };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetVehicleTypes(ComboBox cbx)
        {
            var data = await _vehicleTypeAPIService.Get<List<VehicleTypeDTO>>(null);
            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem
                {
                    Value = item.Id,
                    DisplayText = item.Name
                };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetOrganizationTypes(ComboBox cbx)
        {
            var data = await _organizationTypeAPIService.Get<List<OrganizationTypeDTO>>(null);

            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem { Value = item.Id, DisplayText = item.Name };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetCurrencies(ComboBox cbx)
        {
            var data = await _currencyAPIService.Get<List<CurrencyDTO>>(null);

            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem { Value = item.Id, DisplayText = item.Name };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetCities(ComboBox cbx)
        {
            var data = await _cityAPIService.Get<List<CityDTO>>(null);

            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem { Value = item.Id, DisplayText = item.Name };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetUsers(ComboBox cbx)
        {
            var data = await _userAPIService.Get<List<UserDTO>>(null);

            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem { Value = item.Id, DisplayText = item.Username };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetRoles(ComboBox cbx)
        {
            var data = await _roleAPIService.Get<List<RoleDTO>>(null);

            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem { Value = item.Id, DisplayText = item.Name };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }

        public async Task<ComboBox> GetCategories(ComboBox cbx)
        {
            var data = await _categoryAPIService.Get<List<CategoryDTO>>(null);

            foreach (var item in data)
            {
                var cbxItem = new ComboBoxItem { Value = item.Id, DisplayText = item.Name };

                cbx.Items.Add(cbxItem);
            }

            return cbx;
        }
    }
}
