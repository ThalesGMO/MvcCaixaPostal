using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Configuration;

public class HistoricoPagamentoConfiguration : IEntityTypeConfiguration<HistoricoPagamento>
{
    public void Configure(EntityTypeBuilder<HistoricoPagamento> builder)
    {
        builder.ToTable("historico_pagamento");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("Id");
        builder.Property(x => x.DataPagamento).HasColumnName("data_pagamento").HasColumnType("DATE");
        builder.Property(x => x.MesReferencia).HasColumnName("mes_referencia").HasColumnType("DATE");
        builder.Property(x => x.observacao).HasColumnName("observacao");
        builder.Property(x => x.ValorPago).HasColumnName("valor_pago");
        builder.Property(x => x.IdCaixaPostal).HasColumnName("id_caixa_postal");

        builder.HasOne(x => x.CaixaPostal)
            .WithMany()
            .HasForeignKey(x => x.IdCaixaPostal);
    }
}