using AutoMapper;
using Galeri.Core.DTOs;
using Galeri.Core.Models;
using Galeri.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Galeri.Web.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriService _service;
        private readonly IMapper _mapper;

        public KategoriController(IKategoriService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var kategori = await _service.GetAllAsync();
            var kategoriDto = _mapper.Map<List<KategoriDto>>(kategori.ToList());
            return View(kategoriDto);
        }
    }
}
