using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Facil.BioCentro.Clientes;

public interface IClienteAppService :  IApplicationService
{
    Task<ClienteDto> GetAsync(Guid id);

    Task<PagedResultDto<ClienteDto>> GetListAsync(GetClienteListDto input);

    Task<ClienteDto> CreateAsync(CreateUpdateClienteDto input);

    Task UpdateAsync(Guid id, CreateUpdateClienteDto input);

    Task DeleteAsync(Guid id);
}
