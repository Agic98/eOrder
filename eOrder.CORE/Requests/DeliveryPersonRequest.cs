using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class DeliveryPersonRequest
    {
        public int PersonId { get; set; }
        public decimal DeliveryRadiusKilometers { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int VehicleTypeId { get; set; }
    }
}
