using eOrder.CORE.Requests;
using System.Collections.Generic;

namespace eOrder.Mobile.Models
{
    public class OrderModel
    {
        public string AdditionalMessage { get; set; }
        public OrderDTO Order { get; set; }
        public List<OrderDetailModel> OrderDetailsList { get; set; }
    }
}
