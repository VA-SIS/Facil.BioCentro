using Volo.Abp.Modularity;

namespace Facil.BioCentro;

public abstract class BioCentroApplicationTestBase<TStartupModule> : BioCentroTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
