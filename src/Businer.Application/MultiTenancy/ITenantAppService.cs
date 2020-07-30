using Abp.Application.Services;
using Businer.MultiTenancy.Dto;

namespace Businer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

