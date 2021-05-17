using Microsoft.Extensions.DependencyInjection;
using Poc.Extension.Methods.Domain.Interfaces;
using Poc.Extension.Methods.Infra.Implements;

namespace Poc.Extension.Methods.WebApi.Registers
{
    public static class RegisterInfra
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
            => services
                    .AddSingleton<IFileServer, FileServer>()
                    .AddSingleton<IProxyService, ProxyService>()
                    .AddSingleton<IRepository, Repository>()
                    .AddSingleton<ISendEmail, SendEmail>();
    }
}
