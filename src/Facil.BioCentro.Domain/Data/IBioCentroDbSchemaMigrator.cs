using System.Threading.Tasks;

namespace Facil.BioCentro.Data;

public interface IBioCentroDbSchemaMigrator
{
    Task MigrateAsync();
}
