using Volo.Abp.Modularity;

namespace Acme.FirstAbp
{
    [DependsOn(
        typeof(FirstAbpApplicationModule),
        typeof(FirstAbpDomainTestModule)
        )]
    public class FirstAbpApplicationTestModule : AbpModule
    {

    }
}