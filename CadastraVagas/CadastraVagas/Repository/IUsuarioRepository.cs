using CadastraVagas.Models;

namespace CadastraVagas.Repository
{
    public interface IUsuarioRepository
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel Criar(UsuarioModel usuario);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> Listar();


    }
}
