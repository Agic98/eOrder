namespace eOrder.CORE.Requests
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationDTO Organization { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte[] Photo { get; set; }
    }
}
