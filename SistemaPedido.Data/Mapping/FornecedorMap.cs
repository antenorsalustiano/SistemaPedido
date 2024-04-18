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
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");
            builder.HasKey(f => f.FornecedorId);

            builder.Property(f => f.RazaoSocial).IsRequired();
            builder.Property(f => f.CNPJ).IsRequired();
            builder.Property(f => f.UF).IsRequired();
            builder.Property(f => f.EmailContato);
            builder.Property(f => f.NomeContato);
            builder.Property(f => f.pedidoId);

            builder.HasMany(f => f.Pedido)
             .WithOne(p => p.Fornecedor)
             .HasForeignKey(p => p.FornecedorId);
        }
    }
}
