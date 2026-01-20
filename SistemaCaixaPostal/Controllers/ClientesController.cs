using Microsoft.AspNetCore.Mvc;

namespace SistemaCaixaPostal.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}