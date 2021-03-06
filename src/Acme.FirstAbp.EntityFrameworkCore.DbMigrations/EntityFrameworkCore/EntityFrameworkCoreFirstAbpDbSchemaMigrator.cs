using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.FirstAbp.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.FirstAbp.EntityFrameworkCore
{
    public class EntityFrameworkCoreFirstAbpDbSchemaMigrator
        : IFirstAbpDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFirstAbpDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FirstAbpMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FirstAbpMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}