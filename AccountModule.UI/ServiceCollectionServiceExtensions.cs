using AccountModule.Core.Entities;
using Agoda.IoC.NetCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddAccountModule(this IServiceCollection services)
            => services.AutoWireAssembly(new[] { typeof(AccountEntity).Assembly }, false);
    }
}
