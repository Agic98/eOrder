namespace eOrder.CORE.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
