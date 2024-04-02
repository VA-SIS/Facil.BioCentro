using Facil.BioCentro.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Facil.BioCentro.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BioCentroEntityFrameworkCoreModule),
    typeof(BioCentroApplicationContractsModule)
    )]
public class BioCentroDbMigratorModule : AbpModule
{
}
