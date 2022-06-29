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
    internal class AraçConfiguration:IEntityTypeConfiguration<Araçlar>
    {
        public void Configure(EntityTypeBuilder<Araçlar> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1,1);
            builder.Property(x => x.Açıklama).HasMaxLength(250);
            builder.Property(x => x.Fiyat).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Marka).HasMaxLength(50);
            builder.Property(x => x.Model).HasMaxLength(50);
            builder.Property(x => x.KmDurumu).HasMaxLength(7);
            builder.Property(x => x.ÜretimYılı).HasMaxLength(4);
            builder.Property(x => x.Renk).HasMaxLength(50);

            builder.HasOne(x => x.Kategori).WithMany(x => x.Araçlar).HasForeignKey(x => x.KategoriId);
            builder.HasData(
                new Araçlar { Id = 1, KategoriId = 1, Marka = "BMW", Model = "3.20i", Açıklama = "Hasarsız",Fiyat=5250,KmDurumu="125000",ÜretimYılı="2010",Renk="sarı" },
                new Araçlar { Id = 2, KategoriId = 1, Marka = "BMW", Model = "5.20i", Açıklama = "Hasarlı",Fiyat=4250,KmDurumu="150000",ÜretimYılı="2009",Renk="beyaz" }

            );

        }
    }
}
