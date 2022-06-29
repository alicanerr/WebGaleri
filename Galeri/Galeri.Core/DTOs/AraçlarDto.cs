using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Core.DTOs
{
    public class AraçlarDto
    {
        public int KategoriId { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Açıklama { get; set; }
        public string? Renk { get; set; }
        public string? ÜretimYılı { get; set; }
        public string? KmDurumu { get; set; }
        public decimal? Fiyat { get; set; }
    }
}
