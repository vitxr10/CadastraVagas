using CadastraVagas.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastraVagas.Controllers
{
    public class LoginController : Controller
    {
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
                    if (loginModel.Login == "teste@teste.com" & loginModel.Senha == "1234")
                    {
                        return RedirectToAction("Index", "Home");
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
