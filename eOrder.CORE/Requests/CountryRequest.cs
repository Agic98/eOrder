using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class CountryRequest
    {
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string Name { get; set; }
        public string Code { get; set; }
        public string PrimaryCurrency { get; set; }
    }
}
