using System;

namespace eOrder.CORE.Requests
{
    public class DiscountSearchRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Percentage { get; set; }
    }
}
