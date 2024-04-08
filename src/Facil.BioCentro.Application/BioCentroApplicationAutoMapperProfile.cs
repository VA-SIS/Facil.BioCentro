using AutoMapper;
using Facil.BioCentro.Clientes;
using Facil.BioCentro.Entities.Pessoas;

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
      
    }
}
