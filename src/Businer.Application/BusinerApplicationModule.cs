using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Businer.Authorization;

namespace Businer
{
    [DependsOn(
        typeof(BusinerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BusinerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BusinerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BusinerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
