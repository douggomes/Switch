using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class ProcurandoPorConfiguration : IEntityTypeConfiguration<ProcurandoPor>
    {


        public void Configure(EntityTypeBuilder<ProcurandoPor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao);

            builder.HasData(
                new StatusRelacionamento() { Id = 1, Descricao = "NaoEspecificado" },
                new StatusRelacionamento() { Id = 2, Descricao = "Namoro" },
                new StatusRelacionamento() { Id = 3, Descricao = "Amizade" },
                new StatusRelacionamento() { Id = 4, Descricao = "RelacionamentoSerio" }
                );


        }
    }
}
