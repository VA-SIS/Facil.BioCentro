using System.Threading.Tasks;
using Facil.BioCentro.Localization;
using Facil.BioCentro.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Facil.BioCentro.Web.Menus;

public class BioCentroMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<BioCentroResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                BioCentroMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

       


        

       

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        context.Menu.AddItem(
               new ApplicationMenuItem(
                   BioCentroMenus.Cadastro,
                  l["Menu:Cadastro"],
                   icon: "fa fa-id-card-o",
                   order: 1
               ).AddItem(
                   new ApplicationMenuItem(
                       BioCentroMenus.Clientes,
                      l["Menu:Cadastro:Clientes"],
                       icon: "fa fa-handshake-o",
                       url: "/Pages/Clientes"
                   )
               )
               .AddItem(
                   new ApplicationMenuItem(
                       BioCentroMenus.Servicos,
                      l["Menu:Cadastro:Servicos"],
                       icon: "fa fa-cogs",
                       url: "/Pages/Servicos"
                   )
               )
               .AddItem(
                   new ApplicationMenuItem(
                       BioCentroMenus.Profissionais,
                      l["Menu:Cadastro:Profissionais"],
                       icon: "fa fa-users",
                       url: "/Pages/Profissionais"
                   )
               )
           );

        context.Menu.AddItem(
              new ApplicationMenuItem(
                BioCentroMenus.Financeiro,
                 l["Menu:Financeiro"],
                  icon: "fa fa-briefcase", 
                  order: 2
              ).AddItem(
                  new ApplicationMenuItem(
                      BioCentroMenus.Caixa,
                     l["Menu:Financeiro:Caixa"],
                      icon: "fa fa-line-chart",
                      url: "/Pages/Caixa"
                  )
              )
          );

      




        return Task.CompletedTask;
    }
}
