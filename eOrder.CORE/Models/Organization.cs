namespace eOrder.CORE.Models
{
    public class Organization : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; } 
        public string ShortName { get; set; }
        public int DeliveryTimeCalculated { get; set; }
        public int OrganizationTypeId { get; set; }
        public OrganizationType OrganizationType { get; set; }
        public int? CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public double TaxRate { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public bool IsDeleted { get; set; }
    }
}