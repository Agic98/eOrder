namespace eOrder.CORE.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string UID { get; set; }
        public string IPAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal LocationLatitude { get; set; }
        public decimal LocationLongitude { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}