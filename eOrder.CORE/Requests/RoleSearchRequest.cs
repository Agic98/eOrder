namespace eOrder.CORE.Requests
{
    public class RoleSearchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Custom
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion
    }
}
