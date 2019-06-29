namespace eOrder.CORE.Requests
{
    public class OrganizationSearchRequest
    {
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int OrganizationTypeId { get; set; }
        public OrganizationTypeDTO OrganizationType { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyDTO Currency { get; set; }
        public double  AverageProductPriceMax { get; set; }
        public double RatingMin { get; set; }
        public double  DistanceKilometers { get; set; }
        public double DeliveryTimeMinutesMax { get; set; }
        public double CurrentUserLocationLatitude { get; set; }
        public double CurrentUserLocationLongitude { get; set; }
    }
}
