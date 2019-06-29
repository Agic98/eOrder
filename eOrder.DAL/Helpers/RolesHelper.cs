namespace eOrder.DAL.Helpers
{
    public class RolesHelper
    {
        public string GetRoles(params string[] roles)
        {
            if (roles.Length == 0)
            {
                return string.Empty;
            }

            var rolesString = string.Empty;

            foreach (var role in roles)
            {
                rolesString += roles + ",";
            }

            return rolesString;
        }
    }
}
