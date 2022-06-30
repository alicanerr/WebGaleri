using AutoMapper;
using Galeri.Core.DTOs;
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
    public class AracService:GenericServices<Araçlar>, IAracService
    {
        private readonly IAracRepository _aracRepository;
        private readonly IMapper _mapper;

        public AracService(IGenericRepository<Araçlar> repository, IMapper mapper, IAracRepository aracRepository, IGenericUnitOfWork unitofWork) : base(repository, unitofWork)
        {
            _aracRepository = aracRepository;
            _mapper = mapper;
        }

        public async Task<List<AraçlarDto>> GetAllAraclar()
        {
            var araclar = await _aracRepository.GetAllAraclar();
            var araclarDto = _mapper.Map<List<AraçlarDto>>(araclar);
            return araclarDto;
        }
    }
}
