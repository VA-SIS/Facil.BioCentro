using Facil.BioCentro.Samples;
using Xunit;

namespace Facil.BioCentro.EntityFrameworkCore.Domains;

[Collection(BioCentroTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BioCentroEntityFrameworkCoreTestModule>
{

}
