using CadastraVagas.Data;
using CadastraVagas.Models;

namespace CadastraVagas.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepository(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel Criar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
