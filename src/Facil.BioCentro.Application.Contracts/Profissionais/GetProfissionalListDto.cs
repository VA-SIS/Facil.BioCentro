using Volo.Abp.Application.Dtos;

namespace Facil.BioCentro.Profissionais;

public class GetProfissionalListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
