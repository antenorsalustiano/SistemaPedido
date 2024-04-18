using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Data.Mapping
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(p => p.PedidoId);

            builder.Property(p => p.ProdutoId).IsRequired();
            builder.Property(p => p.DataPedido).IsRequired();
            builder.Property(p => p.QuantidadeProdutos).IsRequired();
            builder.Property(p => p.ValorTotalPedido).IsRequired();
            builder.Property(p => p.FornecedorId).IsRequired();

            builder.HasOne(p => p.Produto)
                .WithMany( p => p.Pedido)
                .HasForeignKey(p => p.ProdutoId);

            builder.HasOne(p => p.Fornecedor)
                .WithMany(f => f.Pedido)
                .HasForeignKey(p => p.FornecedorId);
            
        }
    }
}
