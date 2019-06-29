using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class DeliveryPersonOrderRequest
    {
        public int? DeliveryPersonId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int OrderId { get; set; }
    }
}
