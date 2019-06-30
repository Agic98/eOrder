using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using eOrder.Win.Properties;
using System;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmUserRoleRequest : Form
    {
        APIService _userRoleAPIService = new APIService("UserRole");
        ComboBoxHelper _comboBoxHelper = new ComboBoxHelper();
        private int? _id;

        public frmUserRoleRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var request = ControlsHelper.MapControlsToProps(new UserRoleRequest(), gbxUserRoleData);

            if (_id.HasValue)
            {
                await _userRoleAPIService.Update<UserRoleDTO>(_id.Value, request);
            }
            else
            {
                await _userRoleAPIService.Insert<UserRoleDTO>(request);
            }

            Hide();
        }

        private async void frmUserRoleRequest_Load(object sender, EventArgs e)
        {
            if(cbxUserId.Items.Count == 0)
            {
                cbxUserId = await _comboBoxHelper.GetUsers(cbxUserId);
            }
            if (cbxRoleId.Items.Count == 0)
            {
                cbxUserId = await _comboBoxHelper.GetRoles(cbxRoleId);
            }
            if (_id.HasValue)
            {
                var model = await _userRoleAPIService.GetById<UserRoleDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, gbxUserRoleData);
            }
        }

        private void CbxUserId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (cbxUserId.SelectedIndex == -1)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(cbxUserId, Resources.Validation_ReqField);
            //}
            //else
            //{
            //    errorProvider1.SetError(cbxUserId, null);
            //}
        }

        private void CbxRoleId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (cbxRoleId.SelectedIndex == -1)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(cbxRoleId, Resources.Validation_ReqField);
            //}
            //else
            //{
            //    errorProvider1.SetError(cbxRoleId, null);
            //}
        }
    }
}
