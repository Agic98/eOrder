using System;
using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class PersonRequest
    {
        public int UserId { get; set; }
        public UserRequest User { get; set; }
        [MinLength(3, ErrorMessage = nameof(Resources.ReqFieldMinLength3))]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
