using ExemploAPI.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploAPI.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Estado)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Numero)
                .IsRequired()
                .HasColumnType("int");

            // 1 : 1
            builder.HasOne(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(c => c.ClienteId);            

            builder.ToTable("Enderecos");
        }
    }
}