namespace eOrder.CORE.Requests
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public CityDTO City { get; set; }
        public string Username { get; set; }
        public string UID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public string Email { get; set; }
    }
}
