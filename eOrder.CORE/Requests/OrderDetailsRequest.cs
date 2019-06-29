using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class OrderDetailsRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int OrderId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int? ProductId { get; set; }
        public double ProductPrice { get; set; }
        public int Amount { get; set; } = 1;
        public string AdditionalDescription { get; set; }
    }
}
