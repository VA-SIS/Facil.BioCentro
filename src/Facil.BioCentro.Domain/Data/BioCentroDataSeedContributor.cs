using Facil.BioCentro.Entities.Pessoas;
using Facil.BioCentro.Enums;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Facil.BioCentro.Data;

public class BioCentroDataSeedContributor :
        IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Cliente, Guid> _clienteRepository;
    private readonly IRepository<Profissional, Guid> _profissionalRepository;

    public BioCentroDataSeedContributor(IRepository<Cliente, Guid> clienteRepository, IRepository<Profissional, Guid> profissionalRepository)
    {
        _clienteRepository = clienteRepository;
        _profissionalRepository = profissionalRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _clienteRepository.CountAsync() > 0)
        {
            return;
        }

        //var cliente1 = new Cliente
        //{
        //    Nome = "Adenilse Eulina da Cruz",
        //    Email = string.Empty,
        //    Cpf_Cnpj = "070.013.448-42",
        //    TipoPessoa = PessoaType.Fisica
        //};

        //var cliente2 = new Cliente
        //{
        //    Nome = "Darlete Garcia de Mattos",
        //    Email = string.Empty,
        //    Cpf_Cnpj = "576-759-029-04",
        //    TipoPessoa = PessoaType.Fisica
        //};


        await _clienteRepository.InsertAsync(

               new Cliente
               {
                   Nome = "Adenilse Eulina da Cruz",
                   Email = string.Empty,
                   Cpf_Cnpj = "070.013.448-42",
                   TipoPessoa = PessoaType.Fisica
               },
               autoSave: true
           );

        await _clienteRepository.InsertAsync(

              new Cliente
              {
                  Nome = "Darlete Garcia de Mattos",
                  Email = string.Empty,
                  Cpf_Cnpj = "576-759-029-04",
                  TipoPessoa = PessoaType.Fisica
              },
              autoSave: true
          );



        //await _clienteRepository
        //       .InsertManyAsync(new[] { cliente1, cliente2 });



    }
}
