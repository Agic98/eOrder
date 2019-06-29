using System;

namespace eOrder.CORE.Requests
{
    public class UserRatingSearchRequest
    {
        public int Id { get; set; }
        public int? UserFromId { get; set; }
        public UserDTO UserFrom { get; set; }
        public int UserToId { get; set; }
        public UserDTO UserTo { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
