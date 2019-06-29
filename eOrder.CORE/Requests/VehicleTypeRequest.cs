using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class VehicleTypeRequest
    {
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string Name { get; set; }
        public byte[] Icon { get; set; }
        public string IconFileType { get; set; }
    }
}
