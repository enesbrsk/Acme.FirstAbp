using Acme.FirstAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.FirstAbp.Permissions
{
    public class FirstAbpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FirstAbpPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FirstAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FirstAbpResource>(name);
        }
    }
}
