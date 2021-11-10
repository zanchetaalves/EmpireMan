using EmpireMan.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpireMan.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.CodigoBarras)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Imagem)
                .HasColumnType("image");

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.DataCadastro)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(x => x.Ativo)
                .IsRequired()
                .HasDefaultValue(1)
                .HasColumnType("bit");

            builder.ToTable("Produtos");
        }
    }
}
