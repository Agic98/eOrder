using eOrder.CORE.Requests;
using eOrder.Win.Forms.FormsRequest;
using eOrder.Win.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eOrder.Win.Forms
{
    public partial class frmOrganizationCRUD : Form
    {
        APIService _productAPIService = new APIService("Product");

        public frmOrganizationCRUD()
        {
            InitializeComponent();
        }

        private void FrmOrganizationCRUD_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private async void SetData()
        {
            SetProductData();
        }

        private async void SetProductData()
        {
            var request = ControlsHelper.MapControlsToProps(new ProductSearchRequest(), gbxProductFilters);
            request.Category = new CategoryDTO();
            var data = await _productAPIService.Get<List<ProductDTO>>(request);

            dgvProduct.DataSource = data
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    Category = x.Category.Name,
                    x.Price
                }).ToList();
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            frmProductRequest frmProductRequest = new frmProductRequest();
            frmProductRequest.Show();
        }

        private void DgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            int.TryParse(dgvProduct.CurrentRow.Cells["Id"].Value.ToString(), out id);

            frmProductRequest frmProductRequest = new frmProductRequest(id);
            frmProductRequest.Show();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnProductSearch_Click(object sender, EventArgs e)
        {
            SetProductData();
        }
    }
}
