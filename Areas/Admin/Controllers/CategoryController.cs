using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectFrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Categories);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool IsValid = _db.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (IsValid)
            {
                ModelState.AddModelError("Name", "Такая категория уже существует");
                return View();
            }
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Category category =await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Category category)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            Category dbCategory = await _db.Categories.FindAsync(id);
            Category checkedCategory=_db.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());
            if (dbCategory.Id!= checkedCategory.Id)
            {
                ModelState.AddModelError("Name", "Такая категория уже существует");
                return View();
            }
            dbCategory.Name = category.Name;
            dbCategory.Description = category.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}