using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class UserRoleRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int UserId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int RoleId { get; set; }
    }
}
