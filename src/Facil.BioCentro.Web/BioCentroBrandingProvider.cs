using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Facil.BioCentro.Web;

[Dependency(ReplaceServices = true)]
public class BioCentroBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BioCentro";
}
