using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Businer.EntityFrameworkCore;
using Businer.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Businer.Web.Tests
{
    [DependsOn(
        typeof(BusinerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BusinerWebTestModule : AbpModule
    {
        public BusinerWebTestModule(BusinerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BusinerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BusinerWebMvcModule).Assembly);
        }
    }
}