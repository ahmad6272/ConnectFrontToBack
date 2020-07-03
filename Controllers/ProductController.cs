using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectFrontToBack.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        // GET: Product
        public ActionResult Index(int? page)
        {
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Products.Count() / 12);
            ViewBag.ProductCount = _db.Products.Count();
            if (page == null)
            {
                return View(_db.Products.Select(p => new ProductVM
                {
                    Id = p.Id,
                    Price = p.Price,
                    Title = p.Title,
                    Category = p.Category,
                    Image = p.Image
                }).Take(12));
            }
            else
            {
                return View(_db.Products.Select(p => new ProductVM
                {
                    Id = p.Id,
                    Price = p.Price,
                    Title = p.Title,
                    Category = p.Category,
                    Image = p.Image
                }).Skip(((int)page-1)*12).Take(12));
            }
            
        }

        public IActionResult Load(int skip)
        {
            var model = _db.Products.Select(p => new ProductVM
            {
                Id = p.Id,
                Price = p.Price,
                Title = p.Title,
                Category = p.Category,
                Image = p.Image
            }).Skip(skip).Take(8);
            return PartialView("ProductPartial",model);
            
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}