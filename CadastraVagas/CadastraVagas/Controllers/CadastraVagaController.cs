using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class CadastraVagaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
