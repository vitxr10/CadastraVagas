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

        public IActionResult Listar()
        {
            var listaVagas = _vagaRepository.Listar();
            return View(listaVagas);
        }

        public IActionResult Editar(int id)
        {
            VagaModel vaga = _vagaRepository.ListarPorId(id);
            return View(vaga);
        }

        public IActionResult Excluir(int id)
        {
            VagaModel vaga = _vagaRepository.ListarPorId(id);
            return View(vaga);
        }

        [HttpPost]
        public IActionResult Criar(VagaModel vaga)
        {
            _vagaRepository.Criar(vaga);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Editar(VagaModel vaga)
        {
            _vagaRepository.Editar(vaga);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(VagaModel vaga)
        {
            _vagaRepository.Excluir(vaga);
            return RedirectToAction("Listar");
        }

    }
}
