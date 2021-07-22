using ExemploAPI.Business.Interfaces;
using ExemploAPI.Business.Notificacoes;
using ExemploAPI.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploAPI.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuContext>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}