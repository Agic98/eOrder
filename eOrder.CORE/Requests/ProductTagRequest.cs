using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class ProductTagRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int ProductId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int TagId { get; set; }
    }
}
