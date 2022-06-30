using AutoMapper;
using Galeri.Core.DTOs;
using Galeri.Core.Models;
using Galeri.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Galeri.Web.Controllers
{
    public class AraclarController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracService _aracService;
        private readonly IKategoriService _kategoriService;

        public AraclarController(IMapper mapper, IAracService aracService, IKategoriService kategoriService)
        {
            _mapper = mapper;
            _aracService = aracService;
            _kategoriService = kategoriService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _aracService.GetAllAraclar());
        }

        public async Task<IActionResult> Save()
        {
            var kategoriler = await _kategoriService.GetAllAsync();
            var kategoriDto = _mapper.Map<List<KategoriDto>>(kategoriler.ToList());
            ViewBag.kategoriler = new SelectList(kategoriDto, "Id", "Ad");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(AraçlarDto araclarDto)
        {
            if (ModelState.IsValid)
            {
                await _aracService.AddAsync(_mapper.Map<Araçlar>(araclarDto));
                return RedirectToAction(nameof(Index));
            }
            var araclar = await _aracService.GetAllAsync();
            var aracDto = _mapper.Map<List<AraçlarDto>>(araclar.ToList());
            return View();

        }
        public async Task<IActionResult> Update()
        {
            var kategoriler = await _kategoriService.GetAllAsync();
            var kategoriDto = _mapper.Map<List<KategoriDto>>(kategoriler.ToList());
            ViewBag.kategoriler = new SelectList(kategoriDto, "Id", "Ad");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(AraçlarDto araclarDto)
        {
            if (ModelState.IsValid)
            {
                await _aracService.UpdateAsync(_mapper.Map<Araçlar>(araclarDto));
                return RedirectToAction(nameof(Index));
            }
            var araclar = await _aracService.GetAllAsync();
            var aracDto = _mapper.Map<List<AraçlarDto>>(araclar.ToList());
            return View();
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var arac = await _aracService.GetByIdAsync(Id);
            await _aracService.RemoveAsync(arac);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
