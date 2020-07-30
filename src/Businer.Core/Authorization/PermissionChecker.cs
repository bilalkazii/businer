using Abp.Authorization;
using Businer.Authorization.Roles;
using Businer.Authorization.Users;

namespace Businer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
