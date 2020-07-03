using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.Models;
using ConnectFrontToBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ConnectFrontToBack.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class AllUsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;
        public AllUsersController(UserManager<AppUser> userManager, AppDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Fullname = user.Fullname,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };

                usersVM.Add(userVM);
            }
            return View(usersVM);
        }

        public async Task<IActionResult> Edit(string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            UserVM userVM = new UserVM
            {
                UserName = user.UserName,
                Email = user.Email,
                Fullname = user.Fullname,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(userVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string email, AppUser user)
        {
            if (email == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser dbUser = await _userManager.FindByIdAsync(email);
            AppUser checkedUser = _userManager.Users.FirstOrDefault(u => u.Email.ToLower() == user.Email.ToLower());
            if (dbUser.Email != checkedUser.Email)
            {
                ModelState.AddModelError("Name", "Такой пользователь уже существует");
                return View();
            }
            dbUser.Fullname = user.Fullname;
            dbUser.Email = user.Email;
            dbUser.UserName = user.UserName;
            await _userManager.UpdateAsync(dbUser);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            UserVM userVM = new UserVM
            {
                UserName = user.UserName,
                Email = user.Email,
                Fullname = user.Fullname,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(userVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<ActionResult> DeletePost(string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Logout", "Account");
                }
            }
            return RedirectToAction("Index", "Home");
        }
       

    }
}