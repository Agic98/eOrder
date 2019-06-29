namespace eOrder.CORE.Models
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}