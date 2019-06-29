using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class CityRequest
    {
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int CountryId { get; set; }
    }
}
