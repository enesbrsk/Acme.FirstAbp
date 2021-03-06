using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.FirstAbp.Web
{
    [Dependency(ReplaceServices = true)]
    public class FirstAbpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FirstAbp";
    }
}
