namespace eOrder.CORE.Requests
{
    public class DeliveryPersonDTO
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public PersonDTO Person { get; set; }
        public decimal DeliveryRadiusKilometers { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleTypeDTO VehicleType { get; set; }
    }
}
