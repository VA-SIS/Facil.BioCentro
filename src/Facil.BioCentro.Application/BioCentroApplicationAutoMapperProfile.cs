using AutoMapper;
using Facil.BioCentro.Clientes;
using Facil.BioCentro.Entities.Pessoas;
using Facil.BioCentro.Entities.Servicos;
using Facil.BioCentro.Profissionais;
using Facil.BioCentro.Servicos;

namespace Facil.BioCentro;

public class BioCentroApplicationAutoMapperProfile : Profile
{
    public BioCentroApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        // Clientes      

        CreateMap<Cliente, ClienteDto>();  
        CreateMap<CreateUpdateClienteDto, Cliente>();


        // Profissionais      

        CreateMap<Profissional, ProfissionalDto>();
        CreateMap<CreateUpdateProfissionalDto, Profissional>();

        // Servico      

        CreateMap<Servico, ServicoDto>();
        CreateMap<CreateUpdateServicoDto, Servico>();

    }
}
