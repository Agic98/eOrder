namespace eOrder.CORE.Models
{
    public class ProductTag : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public bool IsDeleted { get; set; }
    }
}