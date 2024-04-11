using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Facil.BioCentro.Enums;
using Facil.BioCentro.Profissionais;

namespace Facil.BioCentro.Web.Pages.Cadastro.Profissionais;

public class CreateModalModel : BioCentroPageModel
{
    [BindProperty]
    public CreateProfissionalViewModel Profissional { get; set; }

    private readonly IProfisionalAppService _profissionalAppService;

    public CreateModalModel(IProfisionalAppService profissionalAppService)
    {
        _profissionalAppService = profissionalAppService;

       
    }

    public void OnGet()
    {
        Profissional = new CreateProfissionalViewModel();
    }



    public async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateProfissionalViewModel, CreateUpdateProfissionalDto>(Profissional);

  

        await _profissionalAppService.CreateAsync(dto);

        return NoContent();
    }

    public class CreateProfissionalViewModel
    {
        [Required]
        [StringLength(ProfissionalConsts.NomeMaxLength)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(ProfissionalConsts.EmailMaxLength)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(ProfissionalConsts.ProfissaoMaxLength)]
        public string Profissao { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Cpf_Cnpj { get; set; } = string.Empty;

        public PessoaType TipoPessoa { get; set; } = PessoaType.Fisica;
    }
}