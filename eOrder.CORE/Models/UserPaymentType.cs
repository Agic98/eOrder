using eOrder.CORE.Constants;

namespace eOrder.CORE.Models
{
    public class UserPaymentType : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public PaymentType PaymentType { get; set; }
        public bool IsDeleted { get; set; }
    }
}