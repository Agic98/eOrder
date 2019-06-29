using System.Collections.Generic;

namespace eOrder.CORE.Requests
{
    public class UserAuthDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<UserRoleDTO> UserRoles { get; set; }
    }
}
