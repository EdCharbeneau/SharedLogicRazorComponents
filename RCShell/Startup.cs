using Core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Northwind.DataAccess;
using Northwind.Shared;
using RCShell.Services;

namespace RCShell
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup() => Configuration = new ConfigurationBuilder().AddUserSecrets<Startup>().Build();
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                    .AddNewtonsoftJson();

            services.AddRazorComponents();

            var connection = Configuration["ConnectionStrings:NorthwindDB"];
            services.UseNorthwindDatabase(connection);
            services.AddScoped<INorthwindService, NorthwindService>();
            services.AddScoped<IHelloMessageService, HelloMessageService>();

            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(policy => policy.AllowAnyOrigin());
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting(routes =>
            {
                routes.MapRazorPages();
                routes.MapComponentHub<App>("app");
                routes.MapControllers();
            });
        }
    }
}
