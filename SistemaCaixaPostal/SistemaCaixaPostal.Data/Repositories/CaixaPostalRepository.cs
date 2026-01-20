using SistemaCaixaPostal.Core.Interdaces.Repositories;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Data.Repositories;

public class CaixaPostalRepository : ICaixaPostalRepository
{
    private readonly AppDbContext _context;

    public CaixaPostalRepository(AppDbContext context)
    {
        _context = context;
    }
    public Task AtualizarAsync(CaixaPostal caixaPostal)
    {
        throw new NotImplementedException();
    }

    public Task<CaixaPostal?> BuscarPorIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CriarAsync(CaixaPostal caixaPostal)
    {
        throw new NotImplementedException();
    }

    public Task DeletarAsync(int id)
    {
        throw new NotImplementedException();
    }
}