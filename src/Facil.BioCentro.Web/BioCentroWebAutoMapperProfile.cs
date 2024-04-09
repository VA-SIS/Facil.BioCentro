using AutoMapper;
using Facil.BioCentro.Clientes;
using static Facil.BioCentro.Web.Pages.Cadastro.Clientes.CreateModalModel;
using static Facil.BioCentro.Web.Pages.Cadastro.Clientes.EditModalModel;

namespace Facil.BioCentro.Web;

public class BioCentroWebAutoMapperProfile : Profile
{
    public BioCentroWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.

        CreateMap<ClienteDto, CreateUpdateClienteDto>();
        CreateMap<ClienteDto, EditClienteViewModel>();
        CreateMap<CreateUpdateClienteDto,EditClienteViewModel>();
        CreateMap<EditClienteViewModel, CreateUpdateClienteDto>();
        CreateMap<CreateClienteViewModel, CreateUpdateClienteDto>();
    }
}


// CreateUpdateClienteDto