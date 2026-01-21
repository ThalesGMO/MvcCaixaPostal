namespace SistemaCaixaPostal.Core.Models;

public class Cliente
{
    protected Cliente() {}
    public int Id { get; }
    
    public string Nome { get; private set; }

    public string Email { get; private set; }

    public string Telefone { get; private set; }

    public int IdClienteStatus { get; private set; }

    public ClienteStatus ClienteStatus {get; private set;}
}