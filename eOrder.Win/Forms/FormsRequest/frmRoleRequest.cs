using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
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
            var request = ControlsHelper.MapControlsToProps(new RoleRequest(), gbxRoleData);

            if (_id.HasValue)
            {
                await _roleAPIService.Update<RoleDTO>(_id.Value, request);
            }
            else
            {
                await _roleAPIService.Insert<RoleDTO>(request);
            }

            Hide();
        }

        private async void frmRoleRequest_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _roleAPIService.GetById<RoleDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, gbxRoleData);
            }
        }
    }
}
