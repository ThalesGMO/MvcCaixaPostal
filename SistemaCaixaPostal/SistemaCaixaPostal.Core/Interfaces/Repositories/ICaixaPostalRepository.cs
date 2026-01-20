using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaCaixaPostal.Core.Models;

namespace SistemaCaixaPostal.Core.Interdaces.Repositories;

public interface ICaixaPostalRepository
{
    Task<CaixaPostal?> BuscarPorIdAsync(int id);
    Task CriarAsync(CaixaPostal caixaPostal);
    Task AtualizarAsync(CaixaPostal caixaPostal);
    Task DeletarAsync(int id);
}