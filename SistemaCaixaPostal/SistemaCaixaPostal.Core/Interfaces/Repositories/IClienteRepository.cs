using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Core.Interfaces.Repositories;

public interface IClienteRepository
{
   Task<(IEnumerable<Cliente> lista, int total)> BuscarAsync(int pagina, int tamanhoPagina, string termoBusca);
   Task <Cliente?> BuscarPorIdAsync(int Id);
   Task CriarAsync(Cliente cliente);
   Task AtualizarAsync(Cliente cliente);
   Task DeletarAsync(int Id);
}