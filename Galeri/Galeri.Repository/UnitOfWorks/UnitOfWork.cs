using Galeri.Core.UnitOfWorks;
using Galeri.Repository.AppDbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Repository.UnitOfWorks
{
    public class UnitOfWork :IGenericUnitOfWork
    {
        private readonly AppDbContexts.AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
