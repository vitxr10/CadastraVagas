using CadastraVagas.Models;

namespace CadastraVagas.Repository
{
    public interface IUsuarioRepository
    {
        UsuarioModel Criar(UsuarioModel usuario);

        UsuarioModel Editar (UsuarioModel usuario);


    }
}
