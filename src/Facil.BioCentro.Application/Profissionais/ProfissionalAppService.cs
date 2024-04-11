using Facil.BioCentro.Entities.Pessoas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Facil.BioCentro.Profissionais;

public class ProfissionalAppService : BioCentroAppService, IProfissionalAppService
{
    private readonly IRepository<Profissional, Guid> _profissionalRepository;

    public ProfissionalAppService(IRepository<Profissional, Guid> profissionalRepository)
    {
        _profissionalRepository = profissionalRepository;
    }

    public async Task<ProfissionalDto> CreateAsync(CreateUpdateProfissionalDto input)
    {
        var profissional = new Profissional(input.Nome, input.Email, input.Profissao)
        {
            Nome = input.Nome,
            Email = input.Email,
            Profissao = input.Profissao
   
        };

        await _profissionalRepository.InsertAsync(profissional);

        return ObjectMapper.Map<Profissional, ProfissionalDto>(profissional);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _profissionalRepository.DeleteAsync(id);
    }

    public async Task<ProfissionalDto> GetAsync(Guid id)
    {
        var profissional = await _profissionalRepository.GetAsync(id);
        return ObjectMapper.Map<Profissional, ProfissionalDto>(profissional);
    }

    public async Task<PagedResultDto<ProfissionalDto>> GetListAsync(GetProfissionalListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Profissional.Nome);
        }

        var profissionais = await _profissionalRepository.GetPagedListAsync(input.SkipCount,
           input.MaxResultCount,
           input.Sorting);



        var totalCount = input.Filter == null
            ? await _profissionalRepository.CountAsync()
            : await _profissionalRepository.CountAsync(
                p => p.Nome.Contains(input.Filter));

        return new PagedResultDto<ProfissionalDto>(
                   totalCount,
                   ObjectMapper.Map<List<Profissional>, List<ProfissionalDto>>(profissionais)
               );

    }

    public async Task UpdateAsync(Guid id, CreateUpdateProfissionalDto input)
    {
        var profissional = await _profissionalRepository.GetAsync(id);

        //if (cliente.Nome != input.Nome)
        //{
        //    await _authorManager.ChangeNameAsync(author, input.Name);
        //}

        //profissional.Id = id;
        profissional.Nome = input.Nome;
        profissional.Email = input.Email;
        profissional.Profissao = input.Profissao;

        

        await _profissionalRepository.UpdateAsync(profissional);
    }
}
