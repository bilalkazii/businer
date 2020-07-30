using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Businer.Configuration;
using Businer.Web;

namespace Businer.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BusinerDbContextFactory : IDesignTimeDbContextFactory<BusinerDbContext>
    {
        public BusinerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BusinerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BusinerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BusinerConsts.ConnectionStringName));

            return new BusinerDbContext(builder.Options);
        }
    }
}
