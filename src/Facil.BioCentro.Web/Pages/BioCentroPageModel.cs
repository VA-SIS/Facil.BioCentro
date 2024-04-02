using Facil.BioCentro.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Facil.BioCentro.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BioCentroPageModel : AbpPageModel
{
    protected BioCentroPageModel()
    {
        LocalizationResourceType = typeof(BioCentroResource);
    }
}
