using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using Facil.BioCentro.Enums;
using Facil.BioCentro.Profissionais;
using Volo.Abp.ObjectMapping;
using Facil.BioCentro.Clientes;

namespace Facil.BioCentro.Web.Pages.Cadastro.Profissionais;

public class EditModalModel :   BioCentroPageModel
{
    [BindProperty]
    public EditProfissionalViewModel Profissional { get; set; }

    private readonly IProfisionalAppService _profissionalAppService;

    public EditModalModel(IProfisionalAppService profissionalAppService)
    {
        _profissionalAppService = profissionalAppService;
    }

  

    public async Task OnGetAsync(Guid id)
    {
        var profissionalDto = await _profissionalAppService.GetAsync(id);

        Profissional = ObjectMapper.Map<ProfissionalDto, EditProfissionalViewModel>(profissionalDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _profissionalAppService.UpdateAsync(
            Profissional.Id,
            ObjectMapper.Map<EditProfissionalViewModel, CreateUpdateProfissionalDto>(Profissional)
        );

        return NoContent();
    }

    public class EditProfissionalViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }


        [Required]
        [StringLength(ClienteConsts.NomeMaxLength)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(ClienteConsts.EmailMaxLength)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Cpf_Cnpj { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Profissao { get; set; } = string.Empty;

        public PessoaType TipoPessoa { get; set; } = 0;
    }
}
