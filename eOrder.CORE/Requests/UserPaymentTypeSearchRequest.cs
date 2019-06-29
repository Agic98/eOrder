using eOrder.CORE.Constants;

namespace eOrder.CORE.Requests
{
    public class UserPaymentTypeSearchRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
