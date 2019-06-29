using System;

namespace eOrder.CORE.Models
{
    public class DeliveryPersonOrder : IEntity
    {
        public int Id { get; set; }
        public int? DeliveryPersonId { get; set; }
        public DeliveryPerson DeliveryPerson { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}