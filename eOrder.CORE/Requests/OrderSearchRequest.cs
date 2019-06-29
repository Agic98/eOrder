using eOrder.CORE.Constants;
using System;

namespace eOrder.CORE.Requests
{
    public class OrderSearchRequest
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public PersonDTO Client { get; set; }
        public int? OrganizationId { get; set; }
        public OrganizationDTO Organization { get; set; }
        public decimal Total { get; set; }
        public decimal TotalWithTax { get; set; }
        public int DeliveryTimeEstimated { get; set; }
        public int DeliveryTimeActual { get; set; }
        public int LocationId { get; set; }
        public LocationDTO Location { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyDTO Currency { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public OrderType OrderType { get; set; }
        public PaymentType PaymentType { get; set; }
        public bool IsPayed { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeCompleted { get; set; }
    }
}
