using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using eOrder.Win.Properties;
using System;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmRoleRequest : Form
    {
        APIService _roleAPIService = new APIService("Role");
        private int? _id;

        public frmRoleRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new RoleRequest(), gbxRoleData);

                if (_id.HasValue)
                {
                    await _roleAPIService.Update<RoleDTO>(_id.Value, request);
                }
                else
                {
                    await _roleAPIService.Insert<RoleDTO>(request);
                }

                MessageBox.Show("Successfully saved!");
                Hide();
            }
        }

        private async void frmRoleRequest_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _roleAPIService.GetById<RoleDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, gbxRoleData);
            }
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
    }
}
