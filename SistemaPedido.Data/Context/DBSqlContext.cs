using Microsoft.EntityFrameworkCore;
using SistemaPedido.Data.Mapping;
using SistemaPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Data.Context
{
    public class DBSqlContext : DbContext
    {
        public DBSqlContext(DbContextOptions<DBSqlContext> options) : base(options) { }

        public DbSet<Fornecedor> Fornecedor { get; private set; }
        public DbSet<Produto> Produto { get; private set; }
        public DbSet<Pedido> Pedido { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            // Registrar os mapeamentos das entidades
           
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());


        }
    }
}
