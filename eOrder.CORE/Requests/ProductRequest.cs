using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class ProductRequest
    {
        public int OrganizationId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int CategoryId { get; set; }
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string Name { get; set; }
        public string Description { get; set; }
        //double.MaxValue - not smart to leave this
        //but we can't know with what currency we are working so the max value can't be fixed
        [Range(0.0000001, double.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public double Price { get; set; }
        public byte[] Photo { get; set; }
    }
}
