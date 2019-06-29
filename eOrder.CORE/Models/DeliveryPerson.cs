namespace eOrder.CORE.Models
{
    public class DeliveryPerson : IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public double DeliveryRadiusKilometers { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public bool IsDeleted { get; set; }
    }
}