using EmpireMan.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpireMan.Data.Mappings
{
    public class ClienteEnderecoMapping : IEntityTypeConfiguration<ClienteEndereco>
    {
        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro)
                .IsRequired()
                .HasColumnType("nvarchar(150)");

            builder.Property(x => x.Numero)
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Complemento)
                .HasColumnType("nvarchar(150)");

            builder.Property(x => x.Cep)
                .IsRequired()
                .HasColumnType("nvarchar(8)");

            builder.Property(x => x.Bairro)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(x => x.Estado)
                .IsRequired()
                .HasColumnType("nvarchar(2)");

            builder.ToTable("ClienteEnderecos");
        }
    }
}
