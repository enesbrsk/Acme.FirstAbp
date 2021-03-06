using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.FirstAbp.Data
{
    /* This is used if database provider does't define
     * IFirstAbpDbSchemaMigrator implementation.
     */
    public class NullFirstAbpDbSchemaMigrator : IFirstAbpDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}