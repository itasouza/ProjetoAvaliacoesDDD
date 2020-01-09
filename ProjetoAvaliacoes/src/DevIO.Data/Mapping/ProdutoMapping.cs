using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(e => e.Ativo)
                   .HasMaxLength(1)
                   .IsUnicode(false);

            builder.Property(e => e.DataFabricacao).HasColumnType("datetime");

            builder.Property(e => e.DataValidade).HasColumnType("datetime");

            builder.Property(e => e.DescricaoProduto).HasColumnType("text");

            builder.Property(e => e.FotoProduto)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.NomeProduto)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.ProdutoPromocao)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.ValorProduto).HasColumnType("decimal(18, 2)");
            builder.ToTable("Produtos");
        }
    }
}
