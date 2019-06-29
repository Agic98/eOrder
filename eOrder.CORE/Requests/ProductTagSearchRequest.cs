namespace eOrder.CORE.Requests
{
    public class ProductTagSearchRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int TagId { get; set; }
        public TagDTO Tag { get; set; }
    }
}
