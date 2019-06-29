using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class TagRequest
    {
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string Name { get; set; }
    }
}
