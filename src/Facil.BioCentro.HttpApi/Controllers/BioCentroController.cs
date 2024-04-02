using Facil.BioCentro.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Facil.BioCentro.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BioCentroController : AbpControllerBase
{
    protected BioCentroController()
    {
        LocalizationResource = typeof(BioCentroResource);
    }
}
