using Galeri.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Repository.Configurations
{
    internal class KategoriConfiguration:IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(100);
            builder.HasData(
                new Kategori { Id = 1, Ad = "Sedan" },
                new Kategori { Id = 2, Ad = "Hatchback" },
                new Kategori { Id = 3, Ad = "Cabrio" },
                new Kategori { Id = 4, Ad = "Elektrikli" },
                new Kategori { Id = 5, Ad = "Suv" }
                );

        }


    }
}
