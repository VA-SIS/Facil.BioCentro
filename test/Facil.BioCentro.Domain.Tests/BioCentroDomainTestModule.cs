using Volo.Abp.Modularity;

namespace Facil.BioCentro;

[DependsOn(
    typeof(BioCentroDomainModule),
    typeof(BioCentroTestBaseModule)
)]
public class BioCentroDomainTestModule : AbpModule
{

}
