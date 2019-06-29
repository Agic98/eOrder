namespace eOrder.CORE.Models
{
    public class OrganizationImage : IEntity
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public byte[] File { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public bool IsDeleted { get; set; }
    }
}