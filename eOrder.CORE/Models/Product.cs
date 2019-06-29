using System.Collections.Generic;

namespace eOrder.CORE.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte[] Photo { get; set; }
        public bool IsDeleted { get; set; }
    }
}