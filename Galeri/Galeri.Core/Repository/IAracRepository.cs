using Galeri.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Core.Repository
{
    public interface IAracRepository:IGenericRepository<Araçlar>
    {
        Task<List<Araçlar>> GetAllAraclar();
    }
}
