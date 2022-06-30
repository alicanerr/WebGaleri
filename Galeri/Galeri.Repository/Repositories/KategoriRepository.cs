using Galeri.Core.Models;
using Galeri.Core.Repository;
using Galeri.Repository.AppDbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Repository.Repositories
{
    public class KategoriRepository : GenericRepository<Kategori>, IKategoriRepository
    {
        public KategoriRepository(AppDbContext context) : base(context)
        {
        }
    }
}
