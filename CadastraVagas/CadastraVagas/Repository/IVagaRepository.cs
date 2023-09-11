using CadastraVagas.Models;

namespace CadastraVagas.Repository
{
    public interface IVagaRepository
    {
        VagaModel Adicionar(VagaModel vaga);

        VagaModel ListarPorId(int id);

        VagaModel Editar(VagaModel vaga);

        //VagaModel Deletar();

        List<VagaModel> Listar();
    }
}
