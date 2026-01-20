using System;

namespace SistemaCaixaPostal.Core.Models;

public class HistoricoPagamento
{
    public int Id { get; private set; }

    public int IdCaixaPostal { get; private set; }

    public DateTime DataPagamento { get; private set; }

    public DateTime MesReferencia { get; private set; }

    public decimal ValorPago { get; private set; }

    public string observacao { get; private set; }
    
    public virtual CaixaPostal CaixaPostal { get; set; }
}