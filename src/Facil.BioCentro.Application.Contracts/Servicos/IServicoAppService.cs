using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Facil.BioCentro.Servicos;

public interface IServicoAppService : IApplicationService
{
    Task<ServicoDto> GetAsync(Guid id);

    Task<PagedResultDto<ServicoDto>> GetListAsync(GetServicoListDto input);

    Task<ServicoDto> CreateAsync(CreateUpdateServicoDto input);

    Task UpdateAsync(Guid id, CreateUpdateServicoDto input);

    Task DeleteAsync(Guid id);
}
