using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Core.Interfaces.Repositories;

public interface ICaixaPostalRepository
{
    Task<(IEnumerable<CaixaPostal> lista, int total)> BuscarAsync(int pagina, int tamanhoPagina, string termoBusca);
    Task<CaixaPostal?> BuscarPorIdAsync(int id);
    Task CriarAsync(CaixaPostal caixaPostal);
    Task AtualizarAsync(CaixaPostal caixaPostal);
    Task DeletarAsync(int id);
} 