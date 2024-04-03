using Volo.Abp.Application.Dtos;

namespace Facil.BioCentro.Clientes;

public class GetClienteListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }

}
