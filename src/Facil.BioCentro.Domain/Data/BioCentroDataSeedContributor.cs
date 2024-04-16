using Facil.BioCentro.Entities.Pessoas;
using Facil.BioCentro.Entities.Servicos;
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
    private readonly IRepository<Servico, Guid> _servicoRepository;

    public BioCentroDataSeedContributor(IRepository<Cliente, Guid> clienteRepository, IRepository<Profissional, Guid> profissionalRepository, IRepository<Servico, Guid> servicoRepository)
    {
        _clienteRepository = clienteRepository;
        _profissionalRepository = profissionalRepository;
        _servicoRepository = servicoRepository;
    }

    //public BioCentroDataSeedContributor(IRepository<Cliente, Guid> clienteRepository, IRepository<Profissional, Guid> profissionalRepository)
    //{
    //    _clienteRepository = clienteRepository;
    //    _profissionalRepository = profissionalRepository;
    //}

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _servicoRepository.CountAsync() == 0)
        {
            await _servicoRepository.InsertAsync(

                new Servico("Consulta Psico"),
                autoSave: true
            );

            await _servicoRepository.InsertAsync(

                  new Servico("Consulta Fono"),
                  autoSave: true
              );

            return;
        }









        //await _profissionalRepository.InsertAsync(

        //      new Profissional
        //      {
        //          Nome = "Cristiane Andréia Soares",
        //          Email = string.Empty,
        //          Profissao = string.Empty,
        //      },
        //      autoSave: true
        //  );

        //await _profissionalRepository.InsertAsync(

        //     new Profissional
        //     {
        //         Nome = "Géssica Araújo Leite da Silva",
        //         Email = string.Empty,
        //         Profissao = "Psicóloga",
        //     },
        //     autoSave: true
        // );

        //await _profissionalRepository.InsertAsync(

        //     new Profissional
        //     {
        //         Nome = "Mariana dos Santos Dias",
        //         Email = string.Empty,
        //         Profissao = "Fonoaudióloga",
        //     },
        //     autoSave: true
        // );



        //await _clienteRepository.InsertAsync(

        //       new Cliente
        //       {
        //           Nome = "Adenilse Eulina da Cruz",
        //           Email = string.Empty,
        //           Cpf_Cnpj = "070.013.448-42",
        //           TipoPessoa = PessoaType.Fisica
        //       },
        //       autoSave: true
        //   );

        //await _clienteRepository.InsertAsync(

        //      new Cliente
        //      {
        //          Nome = "Darlete Garcia de Mattos",
        //          Email = string.Empty,
        //          Cpf_Cnpj = "576-759-029-04",
        //          TipoPessoa = PessoaType.Fisica
        //      },
        //      autoSave: true
        //  );






    }
}
