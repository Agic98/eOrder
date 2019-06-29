using eOrder.CORE.Models;

namespace eOrder.CORE.Requests
{
    public class OrganizationDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int DeliveryTimeCalculated { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public double TaxRate { get; set; }
        public int OrganizationTypeId { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public OrganizationTypeDTO OrganizationType { get; set; }
        public double DistanceFromCurrentUser { get; set; }
        public double AverageRating { get; set; }
        public int TotalNumberOfRatings { get; set; }
        public double AverageProductPrice { get; set; }
    }
}
