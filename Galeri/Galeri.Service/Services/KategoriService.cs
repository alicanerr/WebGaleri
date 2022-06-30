using Galeri.Core.Models;
using Galeri.Core.Repository;
using Galeri.Core.Services;
using Galeri.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Service.Services
{
    public class KategoriService : GenericServices<Kategori>, IKategoriService
    {
        public KategoriService(IGenericRepository<Kategori> repository, IGenericUnitOfWork unitofWork) : base(repository, unitofWork)
        {
        }
    }
}
