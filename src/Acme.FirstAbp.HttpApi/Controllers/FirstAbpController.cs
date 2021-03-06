using Acme.FirstAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.FirstAbp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FirstAbpController : AbpController
    {
        protected FirstAbpController()
        {
            LocalizationResource = typeof(FirstAbpResource);
        }
    }
}