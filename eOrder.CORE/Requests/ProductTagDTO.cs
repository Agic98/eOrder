namespace eOrder.CORE.Requests
{
    public class ProductTagDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int TagId { get; set; }
        public TagDTO Tag { get; set; }
    }
}
