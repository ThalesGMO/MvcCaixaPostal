
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaCaixaPostal.Core.Models;
using SistemaCaixaPostal.Data;

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