using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Facil.BioCentro.Pages;

public class Index_Tests : BioCentroWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
