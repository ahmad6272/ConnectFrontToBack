using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.Models;
using ConnectFrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        // GET: Home
        public ActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Sliders = _db.Sliders,
                Content = _db.Contents.FirstOrDefault(),
                Categories = _db.Categories,
            };
            return View(model);
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Product product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();

            List<ProductBasketVM> products;
            string exBasket = Request.Cookies["basket"];
            if (exBasket == null)
            {
                products = new List<ProductBasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<ProductBasketVM>>(exBasket);
            }

            ProductBasketVM check = products.FirstOrDefault(p => p.Id == id);
            if (check == null)
            {
                ProductBasketVM pro = new ProductBasketVM
                {
                    Id = product.Id,
                    Image = product.Image,
                    Title = product.Title,
                    Price = product.Price,
                    Count = 1,
                };
                products.Add(pro);
            }
            else
            {
                check.Count++;
            }
            
            string basket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(7) });
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Basket()
        {
            return View(Request.Cookies["basket"]);
        }
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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