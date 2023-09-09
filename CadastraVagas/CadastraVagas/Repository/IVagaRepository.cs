using CadastraVagas.Models;

namespace CadastraVagas.Repository
{
    public interface IVagaRepository
    {
        VagaModel Adicionar(VagaModel vaga);

        VagaModel Editar(VagaModel vaga);

        //VagaModel Deletar();
    }
}
