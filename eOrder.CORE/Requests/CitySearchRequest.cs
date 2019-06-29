

namespace eOrder.CORE.Requests
{
    public class CitySearchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public CountryDTO Country { get; set; }
    }
}
