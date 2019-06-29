using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using System;
using System.Windows.Forms;

namespace eOrder.Win.Forms.FormsRequest
{
    public partial class frmOrderChangeStatus : Form
    {
        APIService _orderAPIService = new APIService("Order");
        int _selectedOrder;
        OrderStatus _orderStatus;
        OrderRequestOrganization request = new OrderRequestOrganization();

        public frmOrderChangeStatus(int selectedOrder, OrderStatus orderStatus)
        {
            InitializeComponent();
            _selectedOrder = selectedOrder;
            _orderStatus = orderStatus;
        }

        private async void FrmOrderChangeStatus_Load(object sender, EventArgs e)
        {
            var orderDTO = await _orderAPIService.GetById<OrderDTO>(_selectedOrder);
            request.OrderStatus = _orderStatus;
            request.DeliveryTimeEstimated = orderDTO.DeliveryTimeEstimated;
        }
    }
}
