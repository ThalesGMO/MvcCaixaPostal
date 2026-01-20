using Microsoft.EntityFrameworkCore;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Socio> Socios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CaixaPostal> CaixasPostais { get; set; }
        public DbSet<HistoricoPagamento> HistoricosPagamentos {get; set;}
        public DbSet<ClienteStatus> ClientesStatus { get; set; }
        public DbSet<AluguelStatus> AlugueisStatus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
