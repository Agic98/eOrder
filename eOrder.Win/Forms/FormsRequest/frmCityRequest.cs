using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using eOrder.Win.Properties;
using System;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmCityRequest : Form
    {
        APIService _cityAPIService = new APIService("City");
        private int? _id;
        ComboBoxHelper cbxHelper = new ComboBoxHelper();

        public frmCityRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new CityRequest(), gbxCityData);

                if (_id.HasValue)
                {
                    await _cityAPIService.Update<CityDTO>(_id.Value, request);
                }
                else
                {
                    await _cityAPIService.Insert<CityDTO>(request);
                }

                Hide();
            }
        }

        private async void frmCityRequest_Load(object sender, EventArgs e)
        {
            if (cbxCountryId.Items.Count == 0)
            {
                cbxCountryId = await cbxHelper.GetCountries(cbxCountryId);
            }
            if (_id.HasValue)
            {
                var model = await _cityAPIService.GetById<CityDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, gbxCityData);
                cbxCountryId.SelectedValue = model.CountryId;
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, Resources.Validation_ReqField);
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }
        }

        private void cbxCountryId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbxCountryId.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbxCountryId, Resources.Validation_ReqField);
            }
            else
            {
                errorProvider1.SetError(cbxCountryId, null);
            }
        }
    }
}
