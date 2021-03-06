using Acme.FirstAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.FirstAbp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FirstAbpEntityFrameworkCoreDbMigrationsModule),
        typeof(FirstAbpApplicationContractsModule)
        )]
    public class FirstAbpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
