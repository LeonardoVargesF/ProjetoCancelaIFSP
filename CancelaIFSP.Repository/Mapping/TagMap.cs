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
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Codigo)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.HasOne(prop => prop.Usuario);
        }
    }
}
