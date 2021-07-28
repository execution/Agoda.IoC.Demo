using Agoda.IoC.NetCore;
using PropertyModule.Core.Entities;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddPropertyModule(this IServiceCollection services)
            => services.AutoWireAssembly(new[] { typeof(PropertyEntity).Assembly }, false);
    }
}
