using Facil.BioCentro.Enums;
using System.ComponentModel.DataAnnotations;

namespace Facil.BioCentro.Clientes;

public class CreateUpdateClienteDto
{
    [Required]
    [StringLength(250)]
    public string Nome { get; set; } = string.Empty;
    [Required]
    [StringLength(150)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Cpf_Cnpj { get; set; } = string.Empty;

    [Required]
    public PessoaType TipoPessoa { get; set; } = PessoaType.Fisica;

}
