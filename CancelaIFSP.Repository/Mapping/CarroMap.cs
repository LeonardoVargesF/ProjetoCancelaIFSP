using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using CancelaIFSP.Domain.Entities;

namespace CancelaIFSP.Repository.Mapping
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Carro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Placa)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Modelo)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Cor)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.HasMany(prop => prop.Usuarios);
        }
    }
}
