using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SistemaCaixaPostal.Core.Interfaces.Repositories;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<(IEnumerable<Cliente> lista, int total)> BuscarAsync(int pagina, int tamanhoPagina, string termoBusca)
    {
        var query = _context.Clientes
            .Include(x => x.ClienteStatus)
            .AsQueryable();

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

    public async Task<Cliente?> BuscarPorIdAsync(int Id)
    {
        return await _context.Clientes
            .Include(x => x.ClienteStatus)
            .FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task AtualizarAsync(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task CriarAsync(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(int Id)
    {
        var cliente = await _context.Clientes.FindAsync(Id);
        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
    }
}