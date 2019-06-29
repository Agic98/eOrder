using eOrder.CORE.Requests;
using eOrder.Win.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmVehicleTypeRequest : Form
    {
        APIService _vehicleTypeAPIService = new APIService("VehicleType");
        VehicleTypeRequest request = new VehicleTypeRequest();
        private int? _id;

        public frmVehicleTypeRequest(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            var fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Icon = file;
                request.IconFileType = Path.GetExtension(openFileDialog1.FileName);

                Image image = Image.FromFile(fileName);
                pbxIconPreview.Image = image;
                pbxIconPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void frmVehicleTypeRequest_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _vehicleTypeAPIService.GetById<VehicleTypeDTO>(_id.Value);

                ControlsHelper.MapPropsToControls(result, gbxVehicleTypeData);

                if(request.Icon != null)
                {
                    var image = request.Icon.AsImage();
                    pbxIconPreview.Image = image;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request = ControlsHelper.MapControlsToProps(request, gbxVehicleTypeData);
            if (_id.HasValue)
            {
                await _vehicleTypeAPIService.Update<VehicleTypeRequest>(_id.Value, request);
            }
            else
            {
                await _vehicleTypeAPIService.Insert<VehicleTypeRequest>(request);
            }

            Hide();
        }
    }
}
