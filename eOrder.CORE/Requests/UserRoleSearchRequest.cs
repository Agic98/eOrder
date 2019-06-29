namespace eOrder.CORE.Requests
{
    public class UserRoleSearchRequest
    {
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public int RoleId { get; set; }
        public RoleDTO Role { get; set; }
    }
}
