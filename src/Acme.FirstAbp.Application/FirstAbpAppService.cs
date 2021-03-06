using System;
using System.Collections.Generic;
using System.Text;
using Acme.FirstAbp.Localization;
using Volo.Abp.Application.Services;

namespace Acme.FirstAbp
{
    /* Inherit your application services from this class.
     */
    public abstract class FirstAbpAppService : ApplicationService
    {
        protected FirstAbpAppService()
        {
            LocalizationResource = typeof(FirstAbpResource);
        }
    }
}
