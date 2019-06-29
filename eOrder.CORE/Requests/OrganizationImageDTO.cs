namespace eOrder.CORE.Requests
{
    public class OrganizationImageDTO
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationDTO Organization { get; set; }
        public byte[] File { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
    }
}
