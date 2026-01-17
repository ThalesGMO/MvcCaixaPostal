using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCaixaPostal.Models;

[Table("caixa_postal")]
public class CaixaPostal
{
    [Column("id")]
    public int Id { get; private set; }

    [Column("id_cliente")]
    public int IdCliente { get; set; }

    [Column("id_socio")]
    public int IdSocio { get; set; }

    [Column("id_aluguel_status")]
    public int IdAluguelStatus { get; set; }

    [Column("codigo")]
    public string Codigo { get; private set; }

    [Column("nome_empresa")]
    public string NomeEmpresa { get; private set; }

    [Column("valor_mensal")]
    public decimal ValorMensal { get; private set; }

    [Column("dia_vencimento")]
    public int DiaVencimento { get; private set; }

    [Column("data_inicio_contrato")]
    public DateTime DataInicioContrato { get; private set; }

    public virtual Cliente Cliente { get; set; }
    public virtual Socio Socio { get; set; }
}
