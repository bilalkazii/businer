using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Businer.EntityFrameworkCore
{
    public static class BusinerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BusinerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BusinerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
