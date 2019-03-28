using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Routing;
using Core.Services;
using Northwind.Shared;
using BlazorShell.Services;

namespace BlazorShell
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<IHelloMessageService, HelloMessageService>();
            services.AddSingleton<INorthwindService, NorthwindService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
