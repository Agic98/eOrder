using eOrder.CORE.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsDetails
{
    public partial class frmOrderDetails : Form
    {
        int _id;
        OrderDTO _orderDTO { get; set; }
        APIService _orderAPIService = new APIService("OrderOrganization");
        APIService _orderDetailsAPIService = new APIService("OrderDetails");

        public frmOrderDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void DgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            int.TryParse(dgvProducts.CurrentRow.Cells["Id"].Value.ToString(), out id);

            var orderItemDTO = await _orderDetailsAPIService.GetById<OrderDetailsDTO>(id);

            gbxAdditionalDescriptionProduct.Text = orderItemDTO.AdditionalDescription;
        }

        private async void FrmOrderDetails_Load(object sender, EventArgs e)
        {
            _orderDTO = (await _orderAPIService.Get<List<OrderDTO>>(new OrderSearchRequest { Id = _id, Location = new LocationDTO(), Currency = new CurrencyDTO() })).FirstOrDefault();
            if (_orderDTO == null)
                _orderDTO = new OrderDTO { Location = new LocationDTO(), Currency = new CurrencyDTO() };


            var orderItemsDTOs = await _orderDetailsAPIService.Get<List<OrderDetailsDTO>>(new OrderDetailsSearchRequest { OrderId = _id, Product = new ProductDTO() });
            dgvProducts.DataSource = orderItemsDTOs.Select(x => new
            {
                x.Id,
                x.Product.Name,
                x.Amount,
                Price = x.ProductPrice,
                Total = x.ProductPrice * x.Amount
            }).ToList();


            var location = _orderDTO.Location;

            gbxAdditionalDescriptionOrder.Text = _orderDTO.AdditionalDescription;
            gbxDeliveryLocation.Text = $"Address: {location.AddressLine}\n" +
                                       $"Person: {location.FirstName} {location.LastName}\n" +
                                       $"Phone number: {location.PhoneNumber}";
            lblPaymentType.Text = _orderDTO.PaymentType.ToString();
            cbxIsPayed.Checked = _orderDTO.IsPayed;
            lblTotal.Text = $"Total: {_orderDTO.Total.ToString()} {_orderDTO.Currency.Name}";
        }
    }
}
