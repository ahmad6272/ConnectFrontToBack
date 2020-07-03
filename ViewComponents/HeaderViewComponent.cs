using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.Models;
using ConnectFrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectFrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.BasketCount = 0;
            ViewBag.BasketPrice = 0;
            string basket = Request.Cookies["basket"];
            if(User.Identity.IsAuthenticated)
            {
                AppUser loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserFullname = loginUser.Fullname;
            }
            if (basket != null)
            {
                List<ProductBasketVM> products = JsonConvert.DeserializeObject<List<ProductBasketVM>>(basket);
                ViewBag.BasketCount = products.Sum(p => p.Count);
                ViewBag.BasketPrice = products.Sum(p => p.Price*p.Count);
            }
            Bio model = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
