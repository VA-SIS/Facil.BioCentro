using System.ComponentModel.DataAnnotations;

namespace Facil.BioCentro.Servicos;

public class CreateUpdateServicoDto
{
    [Required]
    [StringLength(250)]
    public string Descricao { get; set; } = string.Empty;

}
