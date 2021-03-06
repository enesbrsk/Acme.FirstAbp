using Volo.Abp.Settings;

namespace Acme.FirstAbp.Settings
{
    public class FirstAbpSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FirstAbpSettings.MySetting1));
        }
    }
}
