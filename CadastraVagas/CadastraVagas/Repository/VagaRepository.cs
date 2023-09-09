using CadastraVagas.Data;
using CadastraVagas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastraVagas.Repository
{
    public class VagaRepository : IVagaRepository
    {
        private readonly BancoContext _bancoContext;

        // injeção de banco de dados
        public VagaRepository(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }
        public VagaModel Adicionar(VagaModel vaga)
        {
            //insert na tabela vagas e dps commit
            _bancoContext.Vagas.Add(vaga);
            _bancoContext.SaveChanges();
            return vaga;
        }

        //public void Deletar()
       // {
           // _bancoContext.Vagas.ExecuteDelete;

        //}

        public VagaModel Editar(VagaModel vaga)
        {
            _bancoContext.Vagas.Update(vaga);
            _bancoContext.SaveChanges();
            return vaga;
        }
    }
}
