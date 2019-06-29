namespace eOrder.CORE.Models
{
    public class VehicleType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Icon { get; set; }
        public string IconFileType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
