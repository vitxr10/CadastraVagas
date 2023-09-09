using CadastraVagas.Models;
using CadastraVagas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class VagaController : Controller
    {
        private readonly IVagaRepository _vagaRepository;
        public VagaController(IVagaRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(VagaModel vaga)
        {
            _vagaRepository.Adicionar(vaga);
            return RedirectToAction("Index");
        }

    }
}
