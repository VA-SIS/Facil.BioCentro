using Facil.BioCentro.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Facil.BioCentro.Permissions;

public class BioCentroPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BioCentroPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BioCentroPermissions.MyPermission1, L("Permission:MyPermission1"));

     

        var clientesPermission = myGroup.AddPermission(BioCentroPermissions.Clientes.Default, L("Permission:Clientes"));

        clientesPermission.AddChild(BioCentroPermissions.Clientes.Create, L("Permission:Clientes.Create"));
        clientesPermission.AddChild(BioCentroPermissions.Clientes.Edit, L("Permission:Clientes.Edit"));
        clientesPermission.AddChild(BioCentroPermissions.Clientes.Delete, L("Permission:Clientes.Delete"));

        var profissionalPermission = myGroup.AddPermission(BioCentroPermissions.Profissionais.Default, L("Permission:Profissionais"));

        profissionalPermission.AddChild(BioCentroPermissions.Profissionais.Create, L("Permission:Profissionais.Create"));
        profissionalPermission.AddChild(BioCentroPermissions.Profissionais.Edit, L("Permission:Profissionais.Edit"));
        profissionalPermission.AddChild(BioCentroPermissions.Profissionais.Delete, L("Permission:Profissionais.Delete"));


        var servicoPermission = myGroup.AddPermission(BioCentroPermissions.Servicos.Default, L("Permission:Servicos"));

        servicoPermission.AddChild(BioCentroPermissions.Servicos.Create, L("Permission:Servicos.Create"));
        servicoPermission.AddChild(BioCentroPermissions.Servicos.Edit, L("Permission:Servicos.Edit"));
        servicoPermission.AddChild(BioCentroPermissions.Servicos.Delete, L("Permission:Servicos.Delete"));


    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BioCentroResource>(name);
    }
}
