using EmpireMan.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpireMan.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.HasMany(x => x.Produtos)
                .WithOne(x => x.Categoria)
                .HasForeignKey(x => x.CategoriaId);

            builder.ToTable("Categorias");
        }
    }
}
