using Microsoft.EntityFrameworkCore;
using SistemaCaixaPostal.Core.Interfaces.Repositories;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Repositories;

public class SocioRepository : ISocioRepository
{
    private readonly AppDbContext _context;

    public SocioRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<(IEnumerable<Socio> lista, int total)> BuscarAsync(int pagina, int tamanhoPagina, string termoBusca)
    {
        var query = _context.Socios.AsQueryable();

        if (!string.IsNullOrEmpty(termoBusca))
        {
            termoBusca = termoBusca.ToLower();
            query = query.Where(x => x.Nome.ToLower().Contains(termoBusca) || x.Email.ToLower().Contains(termoBusca));
        }

        var total = await query.CountAsync();

        var lista = await query
            .OrderBy(x => x.Nome)
            .Skip((pagina - 1) * tamanhoPagina)
            .Take(tamanhoPagina)
            .ToListAsync();

        return (lista, total);
    }

    public async Task AtualizarAsync(Socio socio)
    {
        _context.Socios.Update(socio);
        await _context.SaveChangesAsync();
    }

    public async Task<Socio> BuscarPorIdAsync(int id)
    {
        return await _context.Socios.FindAsync(id);
    }

    public async Task CriarAsync(Socio socio)
    {
        await _context.Socios.AddAsync(socio);
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int id)
    {
        var socio = await _context.Socios.FindAsync(id);
        _context.Socios.Remove(socio);
        await _context.SaveChangesAsync();
    }
}