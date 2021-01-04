using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Sales.Catalogo.Application.Services;
using Sales.Catalogo.Data;
using Sales.Catalogo.Data.Repository;
using Sales.Catalogo.Domain;
using Sales.Catalogo.Domain.Events;
using Sales.Core.Bus;
using Sales.Core.DomainObjects;

namespace Sales.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
        }
    }
}