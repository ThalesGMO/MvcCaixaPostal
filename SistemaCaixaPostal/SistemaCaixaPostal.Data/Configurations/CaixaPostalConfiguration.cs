using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Configuration;

public class CaixaPostalConfiguration : IEntityTypeConfiguration<CaixaPostal>
{
    public void Configure(EntityTypeBuilder<CaixaPostal> builder)
    {
        builder.ToTable("caixa_postal");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Codigo).HasColumnName("codigo");
        builder.Property(x => x.DataInicioContrato).HasColumnName("data_inicio_contrato").HasColumnType("DATE");
        builder.Property(x => x.DiaVencimento).HasColumnName("dia_vencimento");
        builder.Property(x => x.NomeEmpresa).HasColumnName("nome_empresa");
        builder.Property(x => x.ValorMensal).HasColumnName("valor_mensal");
        builder.Property(x => x.IdAluguelStatus).HasColumnName("id_aluguel_status");
        builder.Property(x => x.IdCliente).HasColumnName("id_cliente");
        builder.Property(x => x.IdSocio).HasColumnName("id_socio");

        builder.HasOne(x => x.Cliente)
            .WithMany()
            .HasForeignKey(x => x.IdCliente);

        builder.HasOne(x => x.Socio)
            .WithMany()
            .HasForeignKey(x => x.IdSocio);

        builder.HasOne(x => x.AluguelStatus)
            .WithMany()
            .HasForeignKey(x => x.IdAluguelStatus);
    }
}
