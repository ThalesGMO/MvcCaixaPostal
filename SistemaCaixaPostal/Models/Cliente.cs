using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCaixaPostal.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; private set; }

        [Column("nome")]
        public string Nome { get; private set; }

        [Column("email")]
        public string Email { get; private set; }

        [Column("telefone")]
        public string Telefone { get; private set; }

        [Column("id_cliente_status")]
        public int IdClienteStatus {get; private set;}
    }
}