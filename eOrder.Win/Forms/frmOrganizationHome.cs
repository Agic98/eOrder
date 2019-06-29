using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using eOrder.Win.Forms.FormsDetails;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace eOrder.Win.Forms
{
    public partial class frmOrganizationHome : Form
    {
        APIService _orderAPIService = new APIService("OrderOrganization");
        APIService _orderDetailsAPIService = new APIService("OrderDetails");
        int _selectedOrderId { get; set; }

        public frmOrganizationHome()
        {
            InitializeComponent();
        }

        private void ultraTabStripControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {

        }

        private async void frmOrganizationHome_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private async void SetData()
        {
            var pendingOrdersSearchObject = new OrderSearchRequest { OrderStatus = OrderStatus.Pending, Client = new PersonDTO(), Location = new LocationDTO() };
            var pendingOrders = await _orderAPIService.Get<List<OrderDTO>>(pendingOrdersSearchObject);
            dgvPendingOrders.DataSource = pendingOrders
                .Select(x => new
                {
                    x.Id,
                    Client = $"{x.Client.FirstName} {x.Client.LastName}",
                    Location = $"Address: {x.Location.AddressLine}, Phone number: {x.Location.PhoneNumber}",
                    x.Total,
                    x.TotalWithTax,
                    OrderType = x.OrderType.ToString(),
                    PaymentType = x.PaymentType.ToString(),
                    x.IsPayed,
                    DateCreated = x.DateTimeCreatedDisplay
                }).ToList();

            var activeOrdersSearchObject = new OrderSearchRequest { OrderStatus = OrderStatus.Processing, Client = new PersonDTO(), Location = new LocationDTO() };
            var activeOrders = await _orderAPIService.Get<List<OrderDTO>>(activeOrdersSearchObject);
            dgvActiveOrders.DataSource = activeOrders
                .Select(x => new
                {
                    x.Id,
                    Client = $"{x.Client.FirstName} {x.Client.LastName}",
                    Location = $"Address: {x.Location.AddressLine}, Phone number: {x.Location.PhoneNumber}",
                    x.Total,
                    x.TotalWithTax,
                    OrderType = x.OrderType.ToString(),
                    PaymentType = x.PaymentType.ToString(),
                    x.IsPayed,
                    DateCreated = x.DateTimeCreatedDisplay
                }).ToList();

            var historyOrdersSearchObject = new OrderSearchRequest { OrderStatus = OrderStatus.Completed, Client = new PersonDTO(), Location = new LocationDTO() };
            var historyOrders = await _orderAPIService.Get<List<OrderDTO>>(historyOrdersSearchObject);
            dgvOrderHistory.DataSource = historyOrders
                .Select(x => new
                {
                    x.Id,
                    Client = $"{x.Client.FirstName} {x.Client.LastName}",
                    Location = $"Address: {x.Location.AddressLine}, Phone number: {x.Location.PhoneNumber}",
                    x.Total,
                    x.TotalWithTax,
                    OrderType = x.OrderType.ToString(),
                    PaymentType = x.PaymentType.ToString(),
                    x.IsPayed,
                    DateCreated = x.DateTimeCreatedDisplay
                }).ToList();
        }

        private void dgvOrderHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvOrderHistory.CurrentRow.Cells["Id"].Value.ToString(), out id);
            SetSelectedOrderData(id);
        }

        private void dgvActiveOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvActiveOrders.CurrentRow.Cells["Id"].Value.ToString(), out id);
            SetSelectedOrderData(id);
        }

        private void dgvPendingOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int.TryParse(dgvPendingOrders.CurrentRow.Cells["Id"].Value.ToString(), out id);

            double total = 0;
            double.TryParse(dgvPendingOrders.CurrentRow.Cells["Total"].Value.ToString(), out total);
            btnTotal.Text = "Total: " + total.ToString();

            SetSelectedOrderData(id);
        }

        private async void SetSelectedOrderData(int id)
        {
            _selectedOrderId = id;
            _orderItemCounter = 0;

            gbxOrderDetailsData.Controls.Clear();

            var searchRequest = new OrderDetailsSearchRequest { OrderId = id, Product = new ProductDTO() };
            var data = await _orderDetailsAPIService.Get<List<OrderDetailsDTO>>(searchRequest);

            foreach (var item in data)
            {
                var buttons = GenerateOrderItem(item.Product.Name, item.Amount);
                gbxOrderDetailsData.Controls.Add(buttons.Item1);
                gbxOrderDetailsData.Controls.Add(buttons.Item2);
            }
        }

        int _orderItemCounter = 0;
        private Tuple<Button, Button> GenerateOrderItem(string itemName, int amount)
        {
            var btnName = new Button
            {
                Text = itemName,
                Location = new Point { X = 0, Y = _orderItemCounter * 33 },
                Width = 157,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };
            var btnAmount = new Button
            {
                Text = amount.ToString(),
                Location = new Point { X = 157, Y = _orderItemCounter * 33 },
                Width = 60,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };

            _orderItemCounter++;

            return new Tuple<Button, Button>(btnName, btnAmount);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            APIService.Username = string.Empty;
            APIService.Password = string.Empty;

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Hide();
        }

        private void BtnRefreshData_Click(object sender, EventArgs e)
        {
            SetData();
        }

        private async void BtnCancel_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId != 0)
            {
                var request = new OrderRequestOrganization
                {
                    OrderStatus = OrderStatus.Cancelled
                };
                await _orderAPIService.Update<OrderDTO>(_selectedOrderId, request);
                SetData();
            }
        }

        private async void BtnProcess_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId != 0)
            {
                var request = new OrderRequestOrganization
                {
                    OrderStatus = OrderStatus.Processing
                };
                await _orderAPIService.Update<OrderDTO>(_selectedOrderId, request);
                SetData();
            }
        }

        private async void BtnDelegate_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId != 0)
            {
                var request = new OrderRequestOrganization
                {
                    OrderStatus = OrderStatus.Delegated
                };
                await _orderAPIService.Update<OrderDTO>(_selectedOrderId, request);
                SetData();
            }
        }

        private void BtnOrderDetails_Click(object sender, EventArgs e)
        {
            if(_selectedOrderId != 0)
            {
                frmOrderDetails frmOrderDetails = new frmOrderDetails(_selectedOrderId);
                frmOrderDetails.Show();
            }
            else
            {
                MessageBox.Show("No order selected!");
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            frmOrganizationCRUD frmOrganizationCRUD = new frmOrganizationCRUD();
            frmOrganizationCRUD.Show();
        }
    }
}
