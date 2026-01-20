using Microsoft.EntityFrameworkCore;
using SistemaCaixaPostal.Core.Interfaces.Repositories;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Repositories;

public class CaixaPostalRepository : ICaixaPostalRepository
{
    private readonly AppDbContext _context;
    public CaixaPostalRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<(IEnumerable<CaixaPostal> lista, int total)> BuscarAsync(int pagina, int tamanhoPagina, string termoBusca)
    {
        var query = _context.CaixasPostais
            .Include(x => x.Cliente)
            .Include(x => x.Socio)
            .Include(x => x.AluguelStatus)
            .AsQueryable();

        if (!string.IsNullOrEmpty(termoBusca))
        {
            termoBusca = termoBusca.ToLower();
            query = query.Where(x => x.Codigo.ToLower().Contains(termoBusca) || x.Cliente.Nome.ToLower().Contains(termoBusca));
        }

        var total = await query.CountAsync();

        var lista = await query
            .OrderBy(x => x.Codigo)
            .Skip((pagina - 1) * tamanhoPagina)
            .Take(tamanhoPagina)
            .ToListAsync();

        return (lista, total);
    }

    public async Task CriarAsync(CaixaPostal caixaPostal)
    {
        await _context.CaixasPostais.AddAsync(caixaPostal);
        await _context.SaveChangesAsync();
    }

    public async Task<CaixaPostal?> BuscarPorIdAsync(int id)
    {
        return await _context.CaixasPostais
         .Include(x => x.Cliente)
         .Include(x => x.Socio)
         .Include(x => x.AluguelStatus)
         .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AtualizarAsync(CaixaPostal caixaPostal)
    {
        _context.CaixasPostais.Update(caixaPostal);
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var caixa = await _context.CaixasPostais.FindAsync(id);
        _context.CaixasPostais.Remove(caixa);
        await _context.SaveChangesAsync();
    }
}