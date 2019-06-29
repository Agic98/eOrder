namespace eOrder.CORE.Models
{
    public class OrganizationType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}