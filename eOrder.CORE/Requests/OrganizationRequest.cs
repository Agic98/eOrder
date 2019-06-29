using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class OrganizationRequest
    {
        public int UserId { get; set; }
        public UserRequest User { get; set; }
        public string Name { get; set; }
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string ShortName { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int OrganizationTypeId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int? CurrencyId { get; set; }
        public double TaxRate { get; set; } = 0.17;
        public byte[] ProfilePhoto { get; set; }
    }
}
