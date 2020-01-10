using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mapping
{
    public class PedidoDetalheMapping : IEntityTypeConfiguration<PedidoDetalhe>
    {
        public void Configure(EntityTypeBuilder<PedidoDetalhe> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(d => d.Pedido)
                .WithMany(p => p.PedidoDetalhe)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PedidoDetalhe_Pedido");

            builder.HasOne(d => d.Produto)
                .WithMany(p => p.PedidoDetalhe)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoDetalhe_Produto");


            builder.Property(e => e.Ativo).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.DataCadastro).HasColumnType("datetime");
            builder.Property(e => e.DataAlteracao).HasColumnType("datetime");


            builder.ToTable("PedidoDetalhes");
        }
    }
}
