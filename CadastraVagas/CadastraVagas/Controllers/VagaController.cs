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

        public IActionResult Editar(int id)
        {
            VagaModel vaga = _vagaRepository.ListarPorId(id);
            return View(vaga);
        }

        public IActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(VagaModel vaga)
        {
            _vagaRepository.Adicionar(vaga);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(VagaModel vaga)
        {
            _vagaRepository.Editar(vaga);
            return RedirectToPage("Home");
        }

        [HttpPost]
        public IActionResult Excluir(VagaModel vaga)
        {
            return View();
        }

    }
}
