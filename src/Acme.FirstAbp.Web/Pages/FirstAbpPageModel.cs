using Acme.FirstAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.FirstAbp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FirstAbpPageModel : AbpPageModel
    {
        protected FirstAbpPageModel()
        {
            LocalizationResourceType = typeof(FirstAbpResource);
        }
    }
}