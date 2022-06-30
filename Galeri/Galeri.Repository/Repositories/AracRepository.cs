using Galeri.Core.Models;
using Galeri.Core.Repository;
using Galeri.Repository.AppDbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Repository.Repositories
{
    public class AracRepository : GenericRepository<Araçlar>, IAracRepository
    {
        public AracRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Araçlar>> GetAllAraclar()
        {
            return await _context.Araçlar.ToListAsync();
        }
    }
}
