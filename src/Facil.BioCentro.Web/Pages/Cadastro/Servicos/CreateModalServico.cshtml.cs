using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Facil.BioCentro.Servicos;

namespace Facil.BioCentro.Web.Pages.Cadastro.Servicos;

public class CreateModalModel : BioCentroPageModel
{
    [BindProperty]
    public CreateServicoViewModel Servico { get; set; }

    private readonly IServicoAppService _servicoAppService;

    public CreateModalModel(IServicoAppService servicoAppService)
    {
        _servicoAppService = servicoAppService;

       
    }

    public void OnGet()
    {
        Servico = new CreateServicoViewModel();
    }



    public async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateServicoViewModel, CreateUpdateServicoDto>(Servico);

  

        await _servicoAppService.CreateAsync(dto);

        return NoContent();
    }

    public class CreateServicoViewModel
    {
        [Required]
        [StringLength(ServicoConstants.DescricaoMaxLength)]
        public string Descricao { get; set; } = string.Empty;

       
    }
}