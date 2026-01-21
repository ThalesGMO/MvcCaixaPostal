using Microsoft.AspNetCore.Mvc;

namespace SistemaCaixaPostal.Controllers
{
    public class SocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}