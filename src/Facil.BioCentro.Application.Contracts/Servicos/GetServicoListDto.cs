using Volo.Abp.Application.Dtos;

namespace Facil.BioCentro.Servicos;

public class GetServicoListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
