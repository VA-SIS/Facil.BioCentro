using AutoMapper;
using Facil.BioCentro.Clientes;
using Facil.BioCentro.Profissionais;
using Facil.BioCentro.Servicos;
using static Facil.BioCentro.Web.Pages.Cadastro.Clientes.CreateModalModel;
using static Facil.BioCentro.Web.Pages.Cadastro.Clientes.EditModalModel;
using static Facil.BioCentro.Web.Pages.Cadastro.Profissionais.CreateModalModel;
using static Facil.BioCentro.Web.Pages.Cadastro.Profissionais.EditModalModel;

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


        CreateMap<ProfissionalDto, CreateUpdateProfissionalDto>();
        CreateMap<ProfissionalDto, EditProfissionalViewModel>();
        CreateMap<CreateUpdateProfissionalDto, EditProfissionalViewModel>();
        CreateMap<EditProfissionalViewModel, CreateUpdateProfissionalDto>();
        CreateMap<CreateProfissionalViewModel, CreateUpdateProfissionalDto>();



        // Servico      

        CreateMap<ServicoDto, CreateUpdateServicoDto>();
        //CreateMap<ServicoDto, EditServicoViewModel>();
        //CreateMap<CreateUpdateServicoDto, EditServicoViewModel>();
        //CreateMap<EditServicoViewModel, CreateUpdateServicoDto>();
        //CreateMap<CreateServicoViewModel, CreateUpdateServicoDto>();




    }
}


// CreateUpdateClienteDto