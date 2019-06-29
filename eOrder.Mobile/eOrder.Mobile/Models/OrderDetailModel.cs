using eOrder.CORE.Requests;

namespace eOrder.Mobile.Models
{
    public class OrderDetailModel
    {
        public OrderDetailsDTO OrderDetail { get; set; }
        public string ProductPhotoUrl { get; set; }
    }
}
