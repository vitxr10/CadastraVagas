using CadastraVagas.Models;
using CadastraVagas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository) 
        { 
           _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            _usuarioRepository.ListarPorId(id);
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            _usuarioRepository.Criar(usuario);
            return RedirectToAction("Index", "Login");
        }
    }
}
