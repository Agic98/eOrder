using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmOrganizationRequest : Form
    {
        APIService _organizationAPIService = new APIService("Organization");
        ComboBoxHelper comboBoxHelper = new ComboBoxHelper();
        OrganizationRequest request = new OrganizationRequest { User = new UserRequest() };

        private int? _id;

        public frmOrganizationRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request = ControlsHelper.MapControlsToProps(request, gbxOrganizationData);
            request.User = ControlsHelper.MapControlsToProps(request.User, gbxUserData);

            var result = await _organizationAPIService.Insert<OrganizationDTO>(request);

            if(result != null && result.Id != 0)
            {
                MessageBox.Show("Successfully saved your new account!");
                Hide();
            }
        }

        private async void frmOrganizationRequest_Load(object sender, EventArgs e)
        {
            if(cbxCityId.Items.Count == 0)
            {
                cbxCityId = await comboBoxHelper.GetCities(cbxCityId);
            }
            if (cbxOrganizationTypeId.Items.Count == 0)
            {
                cbxOrganizationTypeId = await comboBoxHelper.GetOrganizationTypes(cbxOrganizationTypeId);
            }
            if (cbxCurrencyId.Items.Count == 0)
            {
                cbxCurrencyId = await comboBoxHelper.GetCurrencies(cbxCurrencyId);
            }

            if (_id.HasValue)
            {
                var organizationDTO = await _organizationAPIService.GetById<OrganizationDTO>(_id);
                ControlsHelper.MapPropsToControls(organizationDTO, gbxOrganizationData);
                ControlsHelper.MapPropsToControls(organizationDTO.User, gbxUserData);
            }
        }

        private void BtnNewImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            var fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.ProfilePhoto = file;

                Image image = Image.FromFile(fileName);
                pbxProfilePhoto.Image = image;
                pbxProfilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
