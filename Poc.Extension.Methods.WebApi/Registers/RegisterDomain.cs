using Microsoft.Extensions.DependencyInjection;
using Poc.Extension.Methods.Domain.Implements;
using Poc.Extension.Methods.Domain.Interfaces;

namespace Poc.Extension.Methods.WebApi.Registers
{
    public static class RegisterDomain
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
            => services.AddSingleton<IFirstDomain, FirstDomain>();
    }
}
