using eOrder.CORE.Models;
using System;

namespace eOrder.CORE.Requests
{
    public class ProductRatingDTO
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public UserDTO User { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
