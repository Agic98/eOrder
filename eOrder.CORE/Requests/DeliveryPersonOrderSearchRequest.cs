using System;

namespace eOrder.CORE.Requests
{
    public class DeliveryPersonOrderSearchRequest
    {
        public int Id { get; set; }
        public int? DeliveryPersonId { get; set; }
        public DeliveryPersonDTO DeliveryPerson { get; set; }
        public int OrderId { get; set; }
        public OrderDTO Order { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
