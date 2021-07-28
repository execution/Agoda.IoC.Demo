using Common;
using PropertyModule.Core.Entities;
using PropertyModule.Core.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddPropertyModule(this IServiceCollection services)
        {
            /*****************************************************************
            * Register Property module
            *****************************************************************/
            services.AddScoped<IGenericRepo<PropertyEntity>, PropertyRepository>();
            // **** REGISTER GENERIC TYPES ****
            // NOTE: Do not know how many class we registered to IoC!!!!
            //services.AddScoped(typeof(IToolSet<>), typeof(ToolSet<>));
            services.AddScoped(typeof(IToolSet<PropertyEntity>), typeof(ToolSet<PropertyEntity>));
            return services;
        }
    }
}
