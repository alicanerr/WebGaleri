using AutoMapper;
using Galeri.Core.DTOs;
using Galeri.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Service.Mappings
{
    public class MapProfiles:Profile
    {
        public MapProfiles()
        {
            CreateMap<Kategori,KategoriDto>().ReverseMap();
            CreateMap<Araçlar,AraçlarDto>().ReverseMap();
        }
   
    }
}
