using System;
using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class DiscountRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int ProductId { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime? End { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public decimal Percentage { get; set; }
    }
}
