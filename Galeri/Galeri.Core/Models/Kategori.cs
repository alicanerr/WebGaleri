using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Core.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public ICollection<Araçlar> Araçlar { get; set; }
    }
}
