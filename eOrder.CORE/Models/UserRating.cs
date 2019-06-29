using System;

namespace eOrder.CORE.Models
{
    public class UserRating : IEntity
    {
        public int Id { get; set; }
        public int? UserFromId { get; set; }
        public User UserFrom { get; set; }
        public int UserToId { get; set; }
        public User UserTo { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
