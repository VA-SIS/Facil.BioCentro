using Facil.BioCentro.Entities.Pessoas;
using Facil.BioCentro.Entities.Servicos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Facil.BioCentro.Servicos;

public class ServicoAppService : BioCentroAppService, IServicoAppService
{
    private readonly IRepository<Servico, Guid> _servicoRepository;

    public ServicoAppService(IRepository<Servico, Guid> servicoRepository)
    {
        _servicoRepository = servicoRepository;
    }

    public async Task<ServicoDto> CreateAsync(CreateUpdateServicoDto input)
    {
        var servico = new Servico(input.Descricao)
        {
            Descricao = input.Descricao,
          

        };

        await _servicoRepository.InsertAsync(servico);

        return ObjectMapper.Map<Servico, ServicoDto>(servico);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _servicoRepository.DeleteAsync(id);
    }

    public async Task<ServicoDto> GetAsync(Guid id)
    {
        var servico = await _servicoRepository.GetAsync(id);
        return ObjectMapper.Map<Servico, ServicoDto>(servico);
    }

    public async Task<PagedResultDto<ServicoDto>> GetListAsync(GetServicoListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Profissional.Nome);
        }

        var servicos = await _servicoRepository.GetPagedListAsync(input.SkipCount,
           input.MaxResultCount,
           input.Sorting);



        var totalCount = input.Filter == null
            ? await _servicoRepository.CountAsync()
            : await _servicoRepository.CountAsync(
                p => p.Descricao.Contains(input.Filter));

        return new PagedResultDto<ServicoDto>(
                   totalCount,
                   ObjectMapper.Map<List<Servico>, List<ServicoDto>>(servicos)
               );
    }

    public async Task UpdateAsync(Guid id, CreateUpdateServicoDto input)
    {
        var servico = await _servicoRepository.GetAsync(id);

        //if (cliente.Nome != input.Nome)
        //{
        //    await _authorManager.ChangeNameAsync(author, input.Name);
        //}

        //profissional.Id = id;
        servico.Descricao = input.Descricao;
      



        await _servicoRepository.UpdateAsync(servico);
    }
}
