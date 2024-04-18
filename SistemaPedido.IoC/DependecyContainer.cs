using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaPedido.Data.Context;
using SistemaPedido.Data.Repository;
using SistemaPedido.Domain.Interfaces;
using SistemaPedido.Service.Interface;
using SistemaPedido.Service.Services;

namespace SistemaPedido.IoC
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //Repository
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // Services
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddDbContext<DBSqlContext>();

        }

    }
}