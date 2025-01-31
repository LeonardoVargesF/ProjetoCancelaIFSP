using CancelaIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Matricula)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Categoria)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.HasMany(prop => prop.Carros);
        }
    }
}
