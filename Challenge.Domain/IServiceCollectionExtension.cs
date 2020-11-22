using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Service;


namespace Challenge.Domain
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDomainServiceCollection(this IServiceCollection services)
        {

            /****************************************************************************************************************
             *** realizar a ligacao da interface com a classe neste container de injeção de dependência ***
             * 
             *  Transient objects are always different; a new instance is provided to every controller and every service.

             *  Scoped objects are the same within a request, but different across different requests.

             *  Singleton objects are the same for every object and every request.
             
            ****************************************************************************************************************/
            services.AddSingleton<IInitializeDomain, InitializeDomain>();
            services.AddScoped<ISelecionarPedidoDomain, SelecionarPedidoDomain>();
            services.AddScoped<IAtualizarPedidoDomain, AtualizarPedidoDomain>();
            services.AddScoped<IInserirPedidoDomain, InserirPedidoDomain>();
            services.AddScoped<IDeletarPedidoDomain, DeletarPedidoDomain>();
            services.AddScoped<ISelecionarStatusDomain, SelecionarStatusDomain>();
            return services;
        }
    }
}
