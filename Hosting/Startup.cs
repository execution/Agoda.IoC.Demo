// NOTE: Additioanl using from Account module
using AccountModule.Core.Entities;
using AccountModule.Core.Repositories;


using Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace Hosting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)=> Configuration = configuration;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            /*****************************************************************
             * Register Account module
             *****************************************************************/
            services.AddScoped<IGenericRepo<AccountEntity>, AccountRepository>();
            // **** REGISTER GENERIC TYPES ****
            // NOTE: Do not know how many class were registered to IoC!!!!
            //services.AddScoped(typeof(IToolSet<>), typeof(ToolSet<>));
            services.AddScoped(typeof(IToolSet<AccountEntity>), typeof(ToolSet<AccountEntity>));


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
