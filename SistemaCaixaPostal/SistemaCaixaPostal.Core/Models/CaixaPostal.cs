namespace SistemaCaixaPostal.Core.Models;

public class CaixaPostal
{
    public int Id { get; private set; }

    public int IdCliente { get; set; }

    public int IdSocio { get; set; }

    public int IdAluguelStatus { get; set; }

    public string Codigo { get; private set; }

    public string NomeEmpresa { get; private set; }

    public decimal ValorMensal { get; private set; }

    public int DiaVencimento { get; private set; }

    public DateTime DataInicioContrato { get; private set; }

    public virtual Cliente Cliente { get; set; }
    public virtual Socio Socio { get; set; }
}
