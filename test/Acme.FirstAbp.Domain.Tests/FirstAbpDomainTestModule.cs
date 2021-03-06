using Acme.FirstAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.FirstAbp
{
    [DependsOn(
        typeof(FirstAbpEntityFrameworkCoreTestModule)
        )]
    public class FirstAbpDomainTestModule : AbpModule
    {

    }
}