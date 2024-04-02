using Volo.Abp.Modularity;

namespace Facil.BioCentro;

[DependsOn(
    typeof(BioCentroApplicationModule),
    typeof(BioCentroDomainTestModule)
)]
public class BioCentroApplicationTestModule : AbpModule
{

}
