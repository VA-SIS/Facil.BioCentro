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


    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BioCentroResource>(name);
    }
}
