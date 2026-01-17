using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace SistemaCaixaPostal.Models
{
    [Table("historico_pagamento")]
    public class HistoricoPagamento
    {
        [Column("id")]
        public int Id { get; private set; }

        [Column("id_caixa_postal")]
        public int IdCaixaPostal { get; private set; }

        [Column("data_pagamento")]
        public DateTime DataPagamento { get; private set; }

        [Column("mes_referencia")]
        public DateTime MesReferencia { get; private set; }

        [Column("valor_pago")]
        public decimal ValorPago { get; private set; }

        [Column("observacao")]
        public string observacao { get; private set; }

    }
}