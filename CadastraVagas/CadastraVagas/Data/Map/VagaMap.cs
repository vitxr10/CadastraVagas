using CadastraVagas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastraVagas.Data.Map
{
    public class VagaMap : IEntityTypeConfiguration<VagaModel>
    {
        public void Configure(EntityTypeBuilder<VagaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario);
        }
    }
}
