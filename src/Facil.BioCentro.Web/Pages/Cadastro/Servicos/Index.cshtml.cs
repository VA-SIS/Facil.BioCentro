using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Facil.BioCentro.Web.Pages.Cadastro.Servicos;

[Authorize]
public class IndexModel : PageModel
{
    public void OnGet()
    {
    }
}
