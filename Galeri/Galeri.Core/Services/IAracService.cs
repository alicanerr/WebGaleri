using Galeri.Core.DTOs;
using Galeri.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Core.Services
{
    public interface IAracService :IGenericService<Araçlar>
    {
        Task<List<AraçlarDto>> GetAllAraclar();
    }
}
