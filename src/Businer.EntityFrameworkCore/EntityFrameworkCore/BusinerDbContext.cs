using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Businer.Authorization.Roles;
using Businer.Authorization.Users;
using Businer.MultiTenancy;

namespace Businer.EntityFrameworkCore
{
    public class BusinerDbContext : AbpZeroDbContext<Tenant, Role, User, BusinerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BusinerDbContext(DbContextOptions<BusinerDbContext> options)
            : base(options)
        {
        }
    }
}
