using Microsoft.EntityFrameworkCore;
using SistemaCaixaPostal.Models;

namespace SistemaCaixaPostal.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Socio> Socios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CaixaPostal> CaixasPostais { get; set; }
        public DbSet<HistoricoPagamento> HistoricoPagamentos {get; set;}
        public DbSet<ClienteStatus> ClienteStatuses { get; set; }
        public DbSet<AluguelStatus> AluguelStatus { get; set; }
}
