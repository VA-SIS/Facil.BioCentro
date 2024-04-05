using AutoMapper.Internal.Mappers;
using Facil.BioCentro.Clientes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using static Facil.BioCentro.Web.Pages.Cadastro.Clientes.CreateModalModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Facil.BioCentro.Enums;

namespace Facil.BioCentro.Web.Pages.Cadastro.Clientes;

public class EditModalModel : PageModel
{
    [BindProperty]
    public EditClienteViewModel Cliente { get; set; }

    private readonly IClienteAppService _clienteAppService;

    public EditModalModel(IClienteAppService clienteAppService)
    {
        _clienteAppService = clienteAppService;
    }

    public void OnGet()
    {
        Cliente = new EditClienteViewModel();
    }

    public async Task OnGetAsync(Guid id)
    {
        var clienteDto = await _clienteAppService.GetAsync(id);

        //Cliente = ObjectMapper.Map<ClienteDto, EditClienteViewModel>(clienteDto);
    }


    public class EditClienteViewModel
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

        public PessoaType TipoPessoa { get; set; } = 0;
    }
}
