using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using System;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmCountryRequest : Form
    {
        APIService _countryAPIService = new APIService("Country");
        private int? _id;

        public frmCountryRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var request = ControlsHelper.MapControlsToProps(new CountryRequest(), gbxCountryData);

            if (_id.HasValue)
            {
                await _countryAPIService.Update<CountryDTO>(_id.Value, request);
            }
            else
            {
                await _countryAPIService.Insert<CountryDTO>(request);
            }

            Hide();
        }

        private async void frmCountryRequest_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _countryAPIService.GetById<CountryDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, gbxCountryData);
            }
        }
    }
}
