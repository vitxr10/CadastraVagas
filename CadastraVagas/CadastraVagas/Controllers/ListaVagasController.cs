using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class ListaVagasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
