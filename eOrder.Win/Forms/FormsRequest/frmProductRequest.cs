using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmProductRequest : Form
    {
        int? _id;
        APIService _productAPIService = new APIService("Product");
        ComboBoxHelper _comboBoxHelper = new ComboBoxHelper();
        ProductRequest request = new ProductRequest();

        public frmProductRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmProductRequest_Load(object sender, EventArgs e)
        {
            if(cbxCategoryId.Items.Count == 0)
            {
                cbxCategoryId = await _comboBoxHelper.GetCategories(cbxCategoryId);
            }

            if (_id.HasValue)
            {
                var productDTO = await _productAPIService.GetById<ProductDTO>(_id);

                ControlsHelper.MapPropsToControls(productDTO, gbxProductData);

                if (productDTO.Photo != null && productDTO.Photo.Length != 0)
                {
                    var image = productDTO.Photo.AsImage();
                    pbxPhoto.Image = image;
                }
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            request = ControlsHelper.MapControlsToProps(request, gbxProductData);
            try
            {
                request.Price = double.Parse(txtPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Value for price is not valid");
                return;
            }

            if (_id.HasValue)
            {
                await _productAPIService.Update<ProductDTO>(_id.Value, request);
            }
            else
            {
                await _productAPIService.Insert<ProductDTO>(request);
            }

            this.Hide();
            MessageBox.Show("Successfully saved!");
        }

        private void BtnNewImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            var fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Photo = file;

                Image image = Image.FromFile(fileName);
                pbxPhoto.Image = image;
                pbxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
