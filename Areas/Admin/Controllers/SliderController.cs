using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.Helpers;
using ConnectFrontToBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ConnectFrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.SliderCount = _db.Sliders.Count();
            return View(_db.Sliders);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Slider slide = await _db.Sliders.FindAsync(id);
            if(slide==null) return NotFound();
            return View(slide);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Выберите файл фотография!");
                return View();
            }
            if (slider.Photo.MaxLengh(200))
            {
                ModelState.AddModelError("Photo", "Размер фотографии должно быть не больше 200кбит!");
                return View();
            }
            int count = _db.Sliders.Count();
            if (count >= 5)
            {
                ModelState.AddModelError("", "Нельзя добовлять больше 5 изоброжений!");
                return View();
            }

            slider.Image = await slider.Photo.SaveImage(_env.WebRootPath,"image/slider");
            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slide = await _db.Sliders.FindAsync(id);
            if (slide == null) return NotFound();
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slide = await _db.Sliders.FindAsync(id);
            if (slide == null) return NotFound();
            Helper.DeleteImage(_env.WebRootPath, "image/slider", slide.Image);
            _db.Sliders.Remove(slide);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Slider slide = await _db.Sliders.FindAsync(id);
            if (slide == null) return NotFound();
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Slider slider)
        {
            if (id == null) return NotFound();
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Выберите файл фотография!");
                    return View();
                }
                if (slider.Photo.MaxLengh(200))
                {
                    ModelState.AddModelError("Photo", "Размер фотографии должно быть не больше 200кбит!");
                    return View();
                }
                Slider dbSlider = await _db.Sliders.FindAsync(id);
                Helper.DeleteImage(_env.WebRootPath, "image/slider", slider.Image);
                dbSlider.Image = await slider.Photo.SaveImage(_env.WebRootPath, "image/slider");
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}