using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using eOrder.Win.Forms.FormsRequest;
using eOrder.Win.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eOrder.Win.Forms
{
    public partial class frmLogin : Form
    {
        APIService _roleAPIService = new APIService("Role");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var userAuth = new UserAuth();
            ControlsHelper.MapControlsToProps(userAuth, this);
            APIService.Username = userAuth.Username;
            APIService.Password = userAuth.Password;

            var roleSearchRequest = new RoleSearchRequest
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            var roles = await _roleAPIService.Get<List<RoleDTO>>(roleSearchRequest);
            
            if(roles == null || roles.Count == 0)
            {
                MessageBox.Show("Invalid username or invalid password");
            }
            else if(roles.Select(x => x.Name).Contains(UserType.Administrator) ||
                    roles.Select(x => x.Name).Contains(UserType.SuperAdministrator))
            {
                frmAdminHome frmAdminHome = new frmAdminHome();
                //this.Hide();
                frmAdminHome.Show();
            }
            else if(roles.Select(x => x.Name).Contains(UserType.Organization))
            {
                frmOrganizationHome frmHome = new frmOrganizationHome();
                //this.Hide();
                frmHome.Show();
            }
            else 
            {
                MessageBox.Show("Invalid user type");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            frmOrganizationRequest frmOrganizationRequest = new frmOrganizationRequest();
            frmOrganizationRequest.Show();
        }
    }
}
