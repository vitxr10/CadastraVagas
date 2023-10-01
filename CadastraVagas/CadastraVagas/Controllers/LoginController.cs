using CadastraVagas.Models;
using CadastraVagas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuariosRepository;
        public LoginController(IUsuarioRepository usuarioRepository) 
        {
            _usuariosRepository = usuarioRepository;
        }   
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario =_usuariosRepository.BuscarPorLogin(loginModel.Login);
                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = "Senha inválida, tente novamente.";
                    }
                    TempData["MensagemErro"] = "Email e/ou senha inválido(s), tente novamente.";
                }
                return View("Index");
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Não foi possível fazer o login {e.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
