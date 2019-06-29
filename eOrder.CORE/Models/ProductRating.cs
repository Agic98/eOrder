using System;

namespace eOrder.CORE.Models
{
    public class ProductRating : IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
