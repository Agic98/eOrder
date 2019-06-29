using eOrder.CORE.Requests;
using eOrder.Win.Forms.FormsRequest;
using eOrder.Win.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eOrder.Win.Forms
{
    public partial class frmAdminHome : Form
    {
        APIService _categoryAPIService = new APIService("Category");
        APIService _cityAPIService = new APIService("City");
        APIService _countryAPIService = new APIService("Country");
        APIService _roleAPIService = new APIService("Role");
        APIService _userAPIService = new APIService("User");
        APIService _deliveryPersonAPIService = new APIService("DeliveryPerson");
        APIService _organizationAPIService = new APIService("Organization");
        APIService _organizationTypeAPIService = new APIService("OrganizationType");
        APIService _userRoleAPIService = new APIService("UserRole");
        APIService _vehicleTypeAPIService = new APIService("VehicleType");

        ComboBoxHelper cbxHelper = new ComboBoxHelper();

        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void ultraTabStripControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            SetCategoryTab();
            SetCityTab();
            SetCountryTab();
            SetOrganizationsTab();
            SetOrganizationTypeTab();
            SetRoleTab();
            SetUserRoleTab();
            SetVehicleTypeTab();
        }

        #region Set Tabs
        private async void SetCategoryTab()
        {
            var searchObject = ControlsHelper.MapControlsToProps(new CountrySearchRequest(), gbxCategoryFilters);

            var data = await _categoryAPIService.Get<List<CategoryDTO>>(searchObject);
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = data;
        }
        private async void SetCityTab()
        {
            if (cbxCountryId.Items.Count == 0)
            {
                cbxCountryId = await cbxHelper.GetCountries(cbxCountryId);
            }

            var searchObject = ControlsHelper.MapControlsToProps(new CitySearchRequest(), gbxCityFilters);
            searchObject.Country = new CountryDTO();

            var data = await _cityAPIService.Get<List<CityDTO>>(searchObject);
            dgvCity.DataSource = data.Select(x => new
            {
                x.Id,
                x.Name,
                Country = x.Country.Name
            }).ToList();
        }
        private async void SetCountryTab()
        {
            var searchObject = ControlsHelper.MapControlsToProps(new CountrySearchRequest(), gbxCountryFilters);

            var data = await _countryAPIService.Get<List<CountryDTO>>(searchObject);
            dgvCountry.DataSource = data;
        }

        private async void SetRoleTab()
        {
            var searchObject = ControlsHelper.MapControlsToProps(new RoleSearchRequest(), gbxRoleFilters);

            var data = await _roleAPIService.Get<List<RoleDTO>>(searchObject);
            dgvRole.DataSource = data;
        }
        private async void SetOrganizationsTab()
        {
            if (cbxOrganizationTypeId.Items.Count == 0)
            {
                cbxOrganizationTypeId = await cbxHelper.GetOrganizationTypes(cbxOrganizationTypeId);
            }

            var searchObject = ControlsHelper.MapControlsToProps(new OrganizationSearchRequest(), gbxOrganizationFilters);
            searchObject.OrganizationType = new OrganizationTypeDTO();

            var data = await _organizationAPIService.Get<List<OrganizationDTO>>(searchObject);
            dgvOrganization.DataSource = data.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                ShortName = x.ShortName,
                Type = x.OrganizationType.Name
            }).ToList();
        }
        private async void SetOrganizationTypeTab()
        {
            var searchObject = ControlsHelper.MapControlsToProps(new OrganizationTypeSearchRequest(), gbxOrganizationTypeData);

            var data = await _organizationTypeAPIService.Get<List<OrganizationTypeDTO>>(searchObject);
            dgvOrganizationType.DataSource = data;
        }
        private async void SetUserRoleTab()
        {
            var data = await _userRoleAPIService.Get<List<UserRoleDTO>>(new UserRoleSearchRequest
            {
                User = new UserDTO(),
                Role = new RoleDTO()
            });
            dgvUserRole.DataSource = data.Select(x => new
            {
                x.Id,
                User = x.User.Username,
                Role = x.Role.Name
            }).ToList();
        }
        private async void SetVehicleTypeTab()
        {
            var searchObject = ControlsHelper.MapControlsToProps(new VehicleTypeSearchRequest(), gbxVehicleTypeData);

            var data = await _vehicleTypeAPIService.Get<List<VehicleTypeDTO>>(searchObject);
            dgvVehicleType.DataSource = data.Select(x => new
            {
                x.Id,
                x.Name
            }).ToList();
        }
        #endregion

        #region Events
        private void btnCategorySearch_Click(object sender, EventArgs e) => SetCategoryTab();
        private void btnCitySearch_Click(object sender, EventArgs e) => SetCityTab();
        private void btnCountrySearch_Click(object sender, EventArgs e) => SetCountryTab();
        private void btnRoleSearch_Click(object sender, EventArgs e) => SetRoleTab();
        private void btnOrganizationsSearch_Click(object sender, EventArgs e) => SetOrganizationsTab();
        private void btnOrganizationTypeSearch_Click(object sender, EventArgs e) => SetOrganizationTypeTab();
        private void btnUserRoleSearch_Click(object sender, EventArgs e) => SetUserRoleTab();
        private void btnVehicleTypeSearch_Click(object sender, EventArgs e) => SetVehicleTypeTab();
        #endregion


        private void dgvCategory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvCategory.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmCategoryRequest frm = new frmCategoryRequest(id);
            frm.Show();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            frmCategoryRequest frm = new frmCategoryRequest();
            frm.Show();
        }

        private void dgvCity_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvCity.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmCityRequest frm = new frmCityRequest(id);
            frm.Show();
        }

        private void btnCityAdd_Click(object sender, EventArgs e)
        {
            frmCityRequest frm = new frmCityRequest();
            frm.Show();
        }

        private void dgvOrganizationsTable_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {

        }

        private void dgvCountry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvCountry.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmCountryRequest frm = new frmCountryRequest(id);
            frm.Show();
        }

        private void btnCountryAdd_Click(object sender, EventArgs e)
        {
            frmCountryRequest frm = new frmCountryRequest();
            frm.Show();
        }

        private void dgvOrganization_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvOrganizationType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvOrganizationType.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmOrganizationTypeRequest frm = new frmOrganizationTypeRequest(id);
            frm.Show();
        }

        private void btnOrganizationTypeAdd_Click(object sender, EventArgs e)
        {
            frmOrganizationTypeRequest frm = new frmOrganizationTypeRequest();
            frm.Show();
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            frmRoleRequest frm = new frmRoleRequest();
            frm.Show();
        }

        private void dgvRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvRole.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmRoleRequest frm = new frmRoleRequest(id);
            frm.Show();
        }

        private void dgvUserRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvRole.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmUserRoleRequest frm = new frmUserRoleRequest(id);
            frm.Show();
        }

        private void btnUserRoleAdd_Click(object sender, EventArgs e)
        {
            frmUserRoleRequest frm = new frmUserRoleRequest();
            frm.Show();
        }

        private void dgvVehicleType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvRole.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmVehicleTypeRequest frm = new frmVehicleTypeRequest(id);
            frm.Show();
        }

        private void btnVehicleTypeAdd_Click(object sender, EventArgs e)
        {
            frmVehicleTypeRequest frm = new frmVehicleTypeRequest();
            frm.Show();
        }
    }
}
