using eOrder.CORE.Constants;
using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class OrderRequestClient
    {
        public int? OrganizationId { get; set; }
        public int ClientId { get; set; }
        public string AdditionalDescription { get; set; }
        public int CurrencyId { get; set; }
        public int? LocationId { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public PaymentType PaymentType { get; set; }
        public double Total { get; set; }
        public bool OrderAll { get; set; }
    }
}
