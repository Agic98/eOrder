namespace eOrder.CORE.Models
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public string PhoneNumber { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsDeleted { get; set; }
    }
}
