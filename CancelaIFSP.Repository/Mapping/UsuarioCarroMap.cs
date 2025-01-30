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
    public class UsuarioCarroMap : IEntityTypeConfiguration<UsuarioCarro>
    {
        public void Configure(EntityTypeBuilder<UsuarioCarro> builder)
        {
            builder.ToTable("UsuarioCarro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DataCadastro)
                .IsRequired();

            builder.HasOne(prop => prop.Usuario);

            builder.HasOne(prop => prop.Carro);
        }
    }
}
