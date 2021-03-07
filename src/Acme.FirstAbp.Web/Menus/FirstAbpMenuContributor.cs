using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Acme.FirstAbp.Localization;
using Acme.FirstAbp.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.FirstAbp.Web.Menus
{
    public class FirstAbpMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<FirstAbpResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(FirstAbpMenus.Home, l["Menu:Home"], "~/"));

            // Ana menüye kullanici sayfasi 

            context.Menu.AddItem(
            new ApplicationMenuItem(
                "FirstAbpMenus",
                l["Menu:FirstAbpMenus"],
                icon: "fa fa-book"
                ).AddItem(
                 new ApplicationMenuItem(
                "FirstAbpMenus.Kullaniciler",
                 l["Menu:Kullaniciler"],
                    url: "/Kullaniciler"
        )
    )
);
        }
    }
}
