using eOrder.CORE.Constants;

namespace eOrder.CORE.Requests
{
    public class OrderRequestOrganization
    {
        public int DeliveryTimeEstimated { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
