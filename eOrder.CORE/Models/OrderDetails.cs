namespace eOrder.CORE.Models
{
    public class OrderDetails : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double ProductPrice { get; set; }
        public string AdditionalDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}