using DevIO.Business.Interfaces;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DevIO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //configurando o referência do IRepository com o Data Repository (Injeção de dependência)
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IImagemProdutoRepository, ImagemProdutoRepository>();
            services.AddScoped<IPedidoDetalheRepository, PedidoDetalheRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            return services;
        }

    }
}
