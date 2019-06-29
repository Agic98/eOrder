using System;
using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class ProductRatingRequest
    {
        public int? UserId { get; set; }
        public int ProductId { get; set; }
        [Range(1, 5, ErrorMessage = nameof(Resources.RatingBetween1And5))]
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
