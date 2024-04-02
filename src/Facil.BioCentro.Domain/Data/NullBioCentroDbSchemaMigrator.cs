using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Facil.BioCentro.Data;

/* This is used if database provider does't define
 * IBioCentroDbSchemaMigrator implementation.
 */
public class NullBioCentroDbSchemaMigrator : IBioCentroDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
