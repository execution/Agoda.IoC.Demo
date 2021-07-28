using AccountModule.Core.Entities;
using AccountModule.Core.Repositories;
using Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddAccountModule(this IServiceCollection services)
        {
            /*****************************************************************
            * Register Account module
            *****************************************************************/
            services.AddScoped<IGenericRepo<AccountEntity>, AccountRepository>();
            // **** REGISTER GENERIC TYPES ****
            // NOTE: Do not know how many class were registered to IoC!!!!
            //services.AddScoped(typeof(IToolSet<>), typeof(ToolSet<>));
            services.AddScoped(typeof(IToolSet<AccountEntity>), typeof(ToolSet<AccountEntity>));

            return services;

        }
    }
}
