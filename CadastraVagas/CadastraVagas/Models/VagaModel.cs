using System.ComponentModel.DataAnnotations;

namespace CadastraVagas.Models
{
    public class VagaModel
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public string Descricao { get; set; }
        public string Link { get; set; }
        public bool Aprovado { get; set; }
    }
}
