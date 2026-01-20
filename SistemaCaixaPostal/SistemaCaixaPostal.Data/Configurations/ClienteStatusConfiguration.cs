using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Configuration;

public class ClienteStatusConfiguration : IEntityTypeConfiguration<ClienteStatus>
{
    public void Configure(EntityTypeBuilder<ClienteStatus> builder)
    {
        builder.ToTable("cliente_status");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
    }
}
