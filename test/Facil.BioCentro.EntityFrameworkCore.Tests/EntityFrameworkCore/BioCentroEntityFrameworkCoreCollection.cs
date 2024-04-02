using Xunit;

namespace Facil.BioCentro.EntityFrameworkCore;

[CollectionDefinition(BioCentroTestConsts.CollectionDefinitionName)]
public class BioCentroEntityFrameworkCoreCollection : ICollectionFixture<BioCentroEntityFrameworkCoreFixture>
{

}
