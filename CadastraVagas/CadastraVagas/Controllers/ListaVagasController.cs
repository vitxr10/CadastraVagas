using CadastraVagas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class ListaVagasController : Controller
    {
        private readonly IVagaRepository _vagaRepository;
        public ListaVagasController(IVagaRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }
        public IActionResult Index()
        {
            var listaVagas = _vagaRepository.Listar();
            return View(listaVagas);
        }
    }
}
