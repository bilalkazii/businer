using System.Threading.Tasks;
using Businer.Configuration.Dto;

namespace Businer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
