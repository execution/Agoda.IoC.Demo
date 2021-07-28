using Common;
using ContactModule.Core.Entities;
using ContactModule.Core.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddContactModule(this IServiceCollection services)
        {


            /*****************************************************************
             * Register Account module
             *****************************************************************/
            services.AddScoped<IGenericRepo<ContactEntity>, ContactRepository>();
            // **** REGISTER GENERIC TYPES ****
            // NOTE: Do not know how many class we registered to IoC!!!!
            //services.AddScoped(typeof(IToolSet<>), typeof(ToolSet<>));
            services.AddScoped(typeof(IToolSet<ContactEntity>), typeof(ToolSet<ContactEntity>));

            return services;

        }
    }
}
