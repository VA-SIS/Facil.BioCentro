using Facil.BioCentro.Clientes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Facil.BioCentro.Enums;




namespace Facil.BioCentro.Web.Pages.Cadastro.Clientes;

public class CreateModalModel : BioCentroPageModel
{
    [BindProperty]
    public CreateClienteViewModel Cliente { get; set; }

    private readonly IClienteAppService _clienteAppService;

    public CreateModalModel(IClienteAppService clienteAppService)
    {
        _clienteAppService = clienteAppService;

       
    }

    public void OnGet()
    {
        Cliente = new CreateClienteViewModel();
    }



    public async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateClienteViewModel, CreateUpdateClienteDto>(Cliente);

  

        await _clienteAppService.CreateAsync(dto);

        return NoContent();
    }

    public class CreateClienteViewModel
    {
        [Required]
        [StringLength(ClienteConsts.NomeMaxLength)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(ClienteConsts.EmailMaxLength)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Cpf_Cnpj { get; set; } = string.Empty;

        public PessoaType TipoPessoa { get; set; } = PessoaType.Fisica;
    }
}