using Facil.BioCentro.Samples;
using Xunit;

namespace Facil.BioCentro.EntityFrameworkCore.Applications;

[Collection(BioCentroTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BioCentroEntityFrameworkCoreTestModule>
{

}
