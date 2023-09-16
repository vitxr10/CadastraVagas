using CadastraVagas.Data;
using CadastraVagas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CadastraVagas.Repository
{
    public class VagaRepository : IVagaRepository
    {
        private readonly BancoContext _bancoContext;

        public VagaRepository(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }
        public VagaModel Criar(VagaModel vaga)
        {
            //insert na tabela vagas e dps commit
            _bancoContext.Vagas.Add(vaga);
            _bancoContext.SaveChanges();
            return vaga;
        }

        public List<VagaModel> Listar()
        {
            return _bancoContext.Vagas.ToList();
        }

        public VagaModel ListarPorId(int id)
        {
            return _bancoContext.Vagas.FirstOrDefault(x => x.Id == id);

        }

        public VagaModel Editar(VagaModel vaga)
        {
            VagaModel vagaDB = ListarPorId(vaga.Id);

            if (vagaDB == null)
            {
                throw new Exception("Erro: esta vaga não existe");
            }

            vagaDB.Titulo = vaga.Titulo;
            vagaDB.Empresa = vaga.Empresa;
            vagaDB.Descricao = vaga.Descricao;
            vagaDB.Link = vaga.Link;

            _bancoContext.Vagas.Update(vagaDB);
            _bancoContext.SaveChanges();

            return vaga;
        }

        public void Excluir(VagaModel vaga)
        {
            VagaModel vagaDB = ListarPorId(vaga.Id);

            _bancoContext.Vagas.Remove(vagaDB);
            _bancoContext.SaveChanges();
        }
    }
}
