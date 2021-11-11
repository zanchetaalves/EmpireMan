using EmpireMan.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpireMan.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnType("nvarchar(11)");

            builder.Property(x => x.Rg)
                .HasColumnType("nvarchar(10)");

            builder.Property(x => x.DataNascimento)
                .IsRequired()
                .HasColumnType("Date");

            builder.Property(x => x.Ativo)
                .IsRequired()
                .HasDefaultValue(1)
                .HasColumnType("bit");

            builder.HasOne(x => x.ClienteEndereco)
                .WithOne(x => x.Cliente);

            builder.ToTable("Clientes");
        }
    }
}
