using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class CategoryRequest
    {
        [Required(ErrorMessage = nameof(Resources.NameReqField))]
        public string Name { get; set; }
    }
}
