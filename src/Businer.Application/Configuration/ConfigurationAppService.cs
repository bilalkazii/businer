using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Businer.Configuration.Dto;

namespace Businer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BusinerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
