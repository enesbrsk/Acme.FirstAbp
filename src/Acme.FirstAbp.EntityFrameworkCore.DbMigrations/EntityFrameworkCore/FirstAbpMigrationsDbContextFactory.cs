using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.FirstAbp.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class FirstAbpMigrationsDbContextFactory : IDesignTimeDbContextFactory<FirstAbpMigrationsDbContext>
    {
        public FirstAbpMigrationsDbContext CreateDbContext(string[] args)
        {
            FirstAbpEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FirstAbpMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FirstAbpMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.FirstAbp.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
