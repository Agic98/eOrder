using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using eOrder.Win.Properties;
using System;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmCategoryRequest : Form
    {
        APIService _categoryAPIService = new APIService("Category");
        private int? _id;

        public frmCategoryRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new CategoryRequest(), gbxCategoryRequestData);

                if (_id.HasValue)
                {
                    await _categoryAPIService.Update<CategoryDTO>(_id.Value, request);
                }
                else
                {
                    await _categoryAPIService.Insert<CategoryDTO>(request);
                }

                Hide();
            }
        }

        private async void frmCategoryRequest_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _categoryAPIService.GetById<CategoryDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, gbxCategoryRequestData);
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
    }
}
