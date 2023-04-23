using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            MvcOptions.EnableEndpointRouting = false;
        }
    
        public static void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
