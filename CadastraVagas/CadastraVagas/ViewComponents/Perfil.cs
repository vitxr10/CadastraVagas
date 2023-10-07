using CadastraVagas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CadastraVagas.ViewComponents
{
    public class Perfil : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario) ) return null;

            UsuarioModel usuario = JsonSerializer.Deserialize<UsuarioModel>(sessaoUsuario);

            return View(usuario);
        }
    }
}
