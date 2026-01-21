using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Core.Interfaces.Repositories;

public interface ISocioRepository
{
    Task<(IEnumerable<Socio> lista, int total)> BuscarAsync(int pagina, int tamanhoPagina, string termoBusca);
    Task<Socio> BuscarPorIdAsync(int id);
    Task DeletarAsync(int id);
    Task CriarAsync(Socio socio);
    Task AtualizarAsync(Socio socio);


}