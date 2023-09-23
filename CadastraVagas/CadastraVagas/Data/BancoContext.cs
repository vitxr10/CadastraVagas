using CadastraVagas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastraVagas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<VagaModel> Vagas { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
