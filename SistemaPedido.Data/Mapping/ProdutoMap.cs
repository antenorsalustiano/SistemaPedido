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
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.ProdutoId).IsRequired();
            builder.Property(p => p.Codigo).IsRequired();
            builder.Property(p => p.Descricao).IsRequired();
            builder.Property(p => p.DataCadastro).IsRequired();
            builder.Property(p => p.Valor).IsRequired();
        }
    }
}
