using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Usuario");

            builder.Property(e => e.DataCadastro).HasColumnType("datetime");

            builder.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.NomeUsuario)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.ToTable("Usuarios");
        }
    }
}
