using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mapping
{
    public class ImagemProdutoMapping : IEntityTypeConfiguration<ImagemProduto>
    {
        public void Configure(EntityTypeBuilder<ImagemProduto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(d => d.Produto)
                    .WithMany(p => p.ImagemProduto)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImagemProduto_Produto");

            builder.Property(e => e.FotoProduto).HasMaxLength(250).IsUnicode(false);

            builder.Property(e => e.Ativo).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.DataCadastro).HasColumnType("datetime");
            builder.Property(e => e.DataAlteracao).HasColumnType("datetime");


            builder.ToTable("ImagemProdutos");

        }
    }
}
