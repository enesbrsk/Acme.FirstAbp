using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.FirstAbp.EntityFrameworkCore
{
    [DependsOn(
        typeof(FirstAbpEntityFrameworkCoreModule)
        )]
    public class FirstAbpEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FirstAbpMigrationsDbContext>();
        }
    }
}
