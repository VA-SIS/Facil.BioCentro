using Microsoft.AspNetCore.Authorization;

namespace Facil.BioCentro.Web.Pages;

[Authorize]
public class IndexModel : BioCentroPageModel
{
    public void OnGet()
    {

    }
}
