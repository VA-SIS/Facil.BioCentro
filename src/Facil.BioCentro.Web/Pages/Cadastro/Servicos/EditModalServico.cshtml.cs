using Facil.BioCentro.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using Facil.BioCentro.Enums;
using Facil.BioCentro.Clientes;
using Volo.Abp.ObjectMapping;

namespace Facil.BioCentro.Web.Pages.Cadastro.Servicos;

public class EditModalModel :   BioCentroPageModel
{
    [BindProperty]
    public EditServicoViewModel Servico { get; set; }

    private readonly IServicoAppService _servicoAppService;

    public EditModalModel(IServicoAppService servicoAppService)
    {
        _servicoAppService = servicoAppService;
    }

  

    public async Task OnGetAsync(Guid id)
    {
        var servicoDto = await _servicoAppService.GetAsync(id);

        Servico = ObjectMapper.Map<ServicoDto, EditServicoViewModel>(servicoDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _servicoAppService.UpdateAsync(
            Servico.Id,
            ObjectMapper.Map<EditServicoViewModel, CreateUpdateServicoDto>(Servico)
        );

        return NoContent();
    }

    public class EditServicoViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }


        [Required]
        [StringLength(ServicoConstants.DescricaoMaxLength)]
        public string Descricao { get; set; } = string.Empty;

       
    }
}
