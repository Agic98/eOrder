using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class RoleRequest
    {
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string Name { get; set; }
        public string Description { get; set; } 
    }
}
