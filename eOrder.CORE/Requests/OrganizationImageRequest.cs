using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class OrganizationImageRequest
    {
        public int OrganizationId { get; set; }
        [Required(ErrorMessage = nameof(Resources.ReqField))]
        public byte[] File { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
    }
}
