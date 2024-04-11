using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Facil.BioCentro.Profissionais;

public interface IProfissionalAppService : IApplicationService
{
    Task<ProfissionalDto> GetAsync(Guid id);

    Task<PagedResultDto<ProfissionalDto>> GetListAsync(GetProfissionalListDto input);

    Task<ProfissionalDto> CreateAsync(CreateUpdateProfissionalDto input);

    Task UpdateAsync(Guid id, CreateUpdateProfissionalDto input);

    Task DeleteAsync(Guid id);
}
