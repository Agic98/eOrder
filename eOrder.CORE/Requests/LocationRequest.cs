namespace eOrder.CORE.Requests
{
    public class LocationRequest
    {
        public int? PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public int? CityId { get; set; }
        public string PhoneNumber { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public bool IsPrimary { get; set; } = true;
    }
}
