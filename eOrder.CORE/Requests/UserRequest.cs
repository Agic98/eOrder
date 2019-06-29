using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class UserRequest
    {
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public string Username { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public string Password { get; set; }
        public string PasswordConfirmed { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
