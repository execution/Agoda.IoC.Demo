using Agoda.IoC.NetCore;
using ContactModule.Core.Entities;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddContactModule(this IServiceCollection services)   
            => services.AutoWireAssembly(new[] { typeof(ContactEntity).Assembly }, false);
    }
}
