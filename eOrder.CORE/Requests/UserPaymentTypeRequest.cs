using eOrder.CORE.Constants;
using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class UserPaymentTypeRequest
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public PaymentType PaymentType { get; set; }
    }
}
