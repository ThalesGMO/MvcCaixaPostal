using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Nome).HasColumnName("nome");
        builder.Property(x => x.Email).HasColumnName("email");
        builder.Property(x => x.Telefone).HasColumnName("telefone");
        builder.Property(x => x.IdClienteStatus).HasColumnName("id_cliente_status");

        builder.HasOne(x => x.ClienteStatus)
            .WithMany()
            .HasForeignKey(x => x.IdClienteStatus);
    }
}
