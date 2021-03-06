using System.Threading.Tasks;

namespace Acme.FirstAbp.Data
{
    public interface IFirstAbpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
