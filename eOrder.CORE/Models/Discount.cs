using System;

namespace eOrder.CORE.Models
{
    public class Discount : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public decimal Percentage { get; set; }
        public bool IsDeleted { get; set; }
    }
}
