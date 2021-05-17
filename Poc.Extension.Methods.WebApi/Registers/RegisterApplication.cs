using Microsoft.Extensions.DependencyInjection;
using Poc.Extension.Methods.Application.Implements;
using Poc.Extension.Methods.Domain.Interfaces;

namespace Poc.Extension.Methods.WebApi.Registers
{
    public static class RegisterApplication
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
            => services.AddSingleton<IFirstApplication, FirstApplication>();

    }
}
