namespace eOrder.CORE.Requests
{
    public class OrderDetailsDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrderDTO Order { get; set; }
        public int? ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public double ProductPrice { get; set; }
        public int Amount { get; set; }
        public double Total { get { return ProductPrice * Amount; } set { } }
        public string AdditionalDescription { get; set; }
    }
}
