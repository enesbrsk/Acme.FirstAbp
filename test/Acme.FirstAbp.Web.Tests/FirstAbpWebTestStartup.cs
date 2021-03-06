using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Acme.FirstAbp
{
    public class FirstAbpWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<FirstAbpWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}