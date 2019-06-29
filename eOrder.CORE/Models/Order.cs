using eOrder.CORE.Constants;
using System;

namespace eOrder.CORE.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Person Client { get; set; }
        public int? LocationId { get; set; }
        public Location Location { get; set; }
        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public double Total { get; set; }
        public double TotalWithTax { get; set; }
        public int DeliveryTimeEstimated { get; set; }
        public int DeliveryTimeActual { get; set; }
        public string AdditionalDescription { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public OrderType OrderType { get; set; }
        public PaymentType PaymentType { get; set; }
        public bool IsPayed { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeCompleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}