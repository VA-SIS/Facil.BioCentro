using Volo.Abp.Modularity;

namespace Facil.BioCentro;

/* Inherit from this class for your domain layer tests. */
public abstract class BioCentroDomainTestBase<TStartupModule> : BioCentroTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
