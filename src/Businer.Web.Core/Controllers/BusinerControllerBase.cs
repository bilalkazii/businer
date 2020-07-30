using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Businer.Controllers
{
    public abstract class BusinerControllerBase: AbpController
    {
        protected BusinerControllerBase()
        {
            LocalizationSourceName = BusinerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
