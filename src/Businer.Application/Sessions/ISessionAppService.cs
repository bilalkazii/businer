using System.Threading.Tasks;
using Abp.Application.Services;
using Businer.Sessions.Dto;

namespace Businer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
