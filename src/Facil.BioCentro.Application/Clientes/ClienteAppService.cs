using Facil.BioCentro.Entities.Pessoas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Facil.BioCentro.Clientes;

public class ClienteAppService : BioCentroAppService, IClienteAppService
{
    //private readonly IClienteRepository _clienteRepository;
    private readonly IRepository<Cliente, Guid> _clienteRepository;

    public ClienteAppService(IRepository<Cliente, Guid> clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<ClienteDto> CreateAsync(CreateUpdateClienteDto input)
    {

        var cliente = new Cliente
        {
            Nome = input.Nome,
            Email = input.Email,
            Cpf_Cnpj = input.Cpf_Cnpj,
            TipoPessoa = input.TipoPessoa
        };

       await _clienteRepository.InsertAsync(cliente);

        return ObjectMapper.Map<Cliente, ClienteDto>(cliente);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _clienteRepository.DeleteAsync(id);
    }

    public async Task<ClienteDto> GetAsync(Guid id)
    {
        var cliente = await _clienteRepository.GetAsync(id);
        return ObjectMapper.Map<Cliente, ClienteDto>(cliente);
    }

    public async Task<PagedResultDto<ClienteDto>> GetListAsync(GetClienteListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Cliente.Nome);
        }

        var clientes = await _clienteRepository.GetPagedListAsync(input.SkipCount,
           input.MaxResultCount,
           input.Sorting);



        var totalCount = input.Filter == null
            ? await _clienteRepository.CountAsync()
            : await _clienteRepository.CountAsync(
                cliente => cliente.Nome.Contains(input.Filter));

        return new PagedResultDto<ClienteDto>(
                   totalCount,
                   ObjectMapper.Map<List<Cliente>, List<ClienteDto>>(clientes)
               );

    }

    public async Task UpdateAsync(Guid id, CreateUpdateClienteDto input)
    {
        var cliente = await _clienteRepository.GetAsync(id);

        //if (cliente.Nome != input.Nome)
        //{
        //    await _authorManager.ChangeNameAsync(author, input.Name);
        //}

       
        cliente.Nome = input.Nome;
        cliente.Email = input.Email;
        cliente.Cpf_Cnpj = input.Cpf_Cnpj;
        cliente.TipoPessoa = input.TipoPessoa;

        await _clienteRepository.UpdateAsync(cliente);
    }
}
