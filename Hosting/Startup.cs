// NOTE: Additioanl using from Account module
using AccountModule.Core.Entities;
using AccountModule.Core.Repositories;

// NOTE: Additioanl using from Contact module
using ContactModule.Core.Entities;
using ContactModule.Core.Repositories;

// NOTE: Additioanl using from Property module
using PropertyModule.Core.Entities;
using PropertyModule.Core.Repositories;

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



            /*****************************************************************
             * Register Account module
             *****************************************************************/
            services.AddScoped<IGenericRepo<ContactEntity>, ContactRepository>();
            // **** REGISTER GENERIC TYPES ****
            // NOTE: Do not know how many class we registered to IoC!!!!
            //services.AddScoped(typeof(IToolSet<>), typeof(ToolSet<>));
            services.AddScoped(typeof(IToolSet<ContactEntity>), typeof(ToolSet<ContactEntity>));


            /*****************************************************************
            * Register Property module
            *****************************************************************/
            services.AddScoped<IGenericRepo<PropertyEntity>, PropertyRepository>();
            // **** REGISTER GENERIC TYPES ****
            // NOTE: Do not know how many class we registered to IoC!!!!
            //services.AddScoped(typeof(IToolSet<>), typeof(ToolSet<>));
            services.AddScoped(typeof(IToolSet<PropertyEntity>), typeof(ToolSet<PropertyEntity>));


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
