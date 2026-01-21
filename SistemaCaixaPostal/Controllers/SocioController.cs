using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaCaixaPostal.Core.Interfaces.Helpers;
using SistemaCaixaPostal.Core.Interfaces.Repositories;

namespace SistemaCaixaPostal.Controllers
{
    [Route("cadastros/socios")]
    public class SocioController : Controller
    {
        private readonly ISocioRepository _repository;
        private readonly INotification _notification;

        public SocioController(ISocioRepository repository, INotification notificador)
        {
            _repository = repository;
            _notification = notificador;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? pagina, string termoBusca = "")
        {
            var paginaAtual = pagina ?? 1;
            var tamanhoPagina = 10;

            ViewBag.TermoBusca = termoBusca;

            var (socios, total) = await _repository.BuscarAsync(paginaAtual, tamanhoPagina, termoBusca);

            return View(socios);
        }
    }
}