using CadastraVagas.Models;

namespace CadastraVagas.Session
{
    public interface ISessao
    {
        void CriarSessaoUsuario (UsuarioModel usuario);
        void RemoverSessaoUsuario ();
        UsuarioModel BuscarSessaoUsuario ();
    }
}
